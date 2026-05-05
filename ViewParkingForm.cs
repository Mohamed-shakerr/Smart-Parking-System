using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class ViewParkingForm : Form
    {
        private ParkingManager manager;
        private Button[] slotButtons;

        public ViewParkingForm(ParkingManager mgr)
        {
            InitializeComponent();
            manager = mgr;

            slotButtons = new Button[]
            {
                btnSlot1, btnSlot2, btnSlot3, btnSlot4, btnSlot5,
                btnSlot6, btnSlot7, btnSlot8, btnSlot9, btnSlot10,
                btnSlot11, btnSlot12, btnSlot13, btnSlot14, btnSlot15,
                btnSlot16, btnSlot17, btnSlot18, btnSlot19, btnSlot20
            };

            LoadSlots();
        }

        private void LoadSlots()
        {
            ParkingSlot[] slots = manager.GetAllSlots();
            for (int i = 0; i < slotButtons.Length && i < slots.Length; i++)
            {
                if (slots[i].Status == SlotStatus.Occupied)
                {
                    slotButtons[i].BackColor = Color.FromArgb(139, 0, 0);
                    slotButtons[i].Text = slots[i].ParkedCar!.PlateNumber;
                    slotButtons[i].Tag = slots[i];
                }
                else
                {
                    slotButtons[i].BackColor = Color.FromArgb(39, 174, 96);
                    slotButtons[i].Text = $"B{slots[i].SlotNumber}";
                    slotButtons[i].Tag = null;
                }
            }

            // Update summary
            lblAvailableCount.Text = manager.GetAvailableCount().ToString();
            lblOccupiedCount.Text = manager.GetOccupiedCount().ToString();
        }

        private void SlotButton_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            ParkingSlot? slot = clickedBtn.Tag as ParkingSlot;

            if (slot != null && slot.ParkedCar != null)
            {
                TimeSpan duration = slot.ParkedCar.GetParkingDuration();
                string durationStr = duration.TotalHours >= 1
                    ? $"{(int)duration.TotalHours}h {duration.Minutes}m"
                    : $"{duration.Minutes}m";

                double estimatedFee = Math.Ceiling(duration.TotalHours) * ParkingManager.HOURLY_RATE;
                if (estimatedFee < ParkingManager.MINIMUM_FEE) estimatedFee = ParkingManager.MINIMUM_FEE;

                MessageBox.Show(
                    $"Slot B{slot.SlotNumber} Details\n\n" +
                    $"Plate Number: {slot.ParkedCar.PlateNumber}\n" +
                    $"Owner: {slot.ParkedCar.Owner}\n" +
                    $"Color: {slot.ParkedCar.Color}\n" +
                    $"Entry Time: {slot.ParkedCar.EntryTime:yyyy-MM-dd HH:mm:ss}\n" +
                    $"Duration: {durationStr}\n" +
                    $"Estimated Fee: EGP {estimatedFee:F2}",
                    $"Slot B{slot.SlotNumber} - Vehicle Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                int slotNum = int.Parse(clickedBtn.Text.Substring(1));
                MessageBox.Show(
                    $"Slot B{slotNum} is available for parking.",
                    $"Slot B{slotNum}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSlots();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
