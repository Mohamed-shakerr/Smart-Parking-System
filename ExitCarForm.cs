using System;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class ExitCarForm : Form
    {
        private ParkingManager manager;

        public ExitCarForm(ParkingManager mgr)
        {
            InitializeComponent();
            manager = mgr;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string plate = txtPlateNumber.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(plate))
            {
                MessageBox.Show(
                    "Please enter a plate number to search.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ParkingSlot? slot = manager.FindCar(plate);
            if (slot != null && slot.ParkedCar != null)
            {
                TimeSpan duration = slot.ParkedCar.GetParkingDuration();
                double estimatedFee = Math.Ceiling(duration.TotalHours) * ParkingManager.HOURLY_RATE;
                if (estimatedFee < ParkingManager.MINIMUM_FEE) estimatedFee = ParkingManager.MINIMUM_FEE;

                string durationStr = duration.TotalHours >= 1
                    ? $"{(int)duration.TotalHours}h {duration.Minutes}m"
                    : $"{duration.Minutes}m";

                lblResultPlate.Text = $"Plate: {slot.ParkedCar.PlateNumber}";
                lblResultOwner.Text = $"Owner: {slot.ParkedCar.Owner}";
                lblResultColor.Text = $"Color: {slot.ParkedCar.Color}";
                lblResultSlot.Text = $"Slot: B{slot.SlotNumber}";
                lblResultDuration.Text = $"Duration: {durationStr}";
                lblResultFee.Text = $"Fee: EGP {estimatedFee:F2}";
                lblResultEntry.Text = $"Entry: {slot.ParkedCar.EntryTime:HH:mm:ss}";

                pnlResult.Visible = true;
                btnExitCar.Enabled = true;
            }
            else
            {
                MessageBox.Show(
                    "No vehicle found with this plate number.",
                    "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                pnlResult.Visible = false;
                btnExitCar.Enabled = false;
            }
        }

        private void btnExitCar_Click(object sender, EventArgs e)
        {
            string plate = txtPlateNumber.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(plate))
            {
                MessageBox.Show("Please search for a vehicle first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to exit vehicle {plate}?\nA parking fee will be calculated and applied.",
                "Confirm Vehicle Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int slotNumber;
                double fee;
                Car? car = manager.ExitCar(plate, out slotNumber, out fee);

                if (car != null)
                {
                    MessageBox.Show(
                        $"Vehicle exited successfully!\n\nPlate: {car.PlateNumber}\nOwner: {car.Owner}\nSlot: B{slotNumber}\nFee: EGP {fee:F2}",
                        "Exit Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtPlateNumber.Clear();
                    pnlResult.Visible = false;
                    btnExitCar.Enabled = false;
                }
                else
                {
                    MessageBox.Show(
                        "Vehicle not found. It may have already been exited.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlateNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
