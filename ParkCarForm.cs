using System;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class ParkCarForm : Form
    {
        private ParkingManager manager;

        public ParkCarForm(ParkingManager mgr)
        {
            InitializeComponent();
            manager = mgr;
            LoadAvailableSlots();
            cboCarColor.SelectedIndex = 0;
        }

        private void LoadAvailableSlots()
        {
            cboSlotNumber.Items.Clear();
            cboSlotNumber.Items.Add("Auto-Assign");
            ParkingSlot[] slots = manager.GetAllSlots();
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].Status == SlotStatus.Available)
                {
                    cboSlotNumber.Items.Add($"B{slots[i].SlotNumber}");
                }
            }
            cboSlotNumber.SelectedIndex = 0;
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            string plate = txtPlateNumber.Text.Trim().ToUpper();
            string owner = txtOwnerName.Text.Trim();
            string color = cboCarColor.SelectedItem?.ToString() ?? "Other";

            if (string.IsNullOrEmpty(plate))
            {
                MessageBox.Show(
                    "Please enter the vehicle plate number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPlateNumber.Focus();
                return;
            }

            if (string.IsNullOrEmpty(owner))
            {
                MessageBox.Show(
                    "Please enter the owner's name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtOwnerName.Focus();
                return;
            }

            int assignedSlot;

            if (cboSlotNumber.SelectedIndex == 0) // Auto-assign
            {
                bool success = manager.ParkCar(plate, owner, color, out assignedSlot);
                if (success)
                {
                    MessageBox.Show(
                        $"Vehicle parked successfully!\n\nPlate: {plate}\nOwner: {owner}\nColor: {color}\nSlot: B{assignedSlot}",
                        "Parking Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearForm();
                    LoadAvailableSlots();
                }
                else
                {
                    MessageBox.Show(
                        "Parking is full or this vehicle is already parked.",
                        "Parking Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else // Specific slot
            {
                string slotText = cboSlotNumber.SelectedItem.ToString()!;
                int slotNum = int.Parse(slotText.Substring(1));
                bool success = manager.ParkCarInSlot(plate, owner, color, slotNum, out assignedSlot);
                if (success)
                {
                    MessageBox.Show(
                        $"Vehicle parked successfully!\n\nPlate: {plate}\nOwner: {owner}\nColor: {color}\nSlot: B{assignedSlot}",
                        "Parking Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearForm();
                    LoadAvailableSlots();
                }
                else
                {
                    MessageBox.Show(
                        "Selected slot is no longer available, or this vehicle is already parked.",
                        "Parking Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    LoadAvailableSlots();
                }
            }
        }

        private void ClearForm()
        {
            txtPlateNumber.Clear();
            txtOwnerName.Clear();
            cboCarColor.SelectedIndex = 0;
            cboSlotNumber.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlateNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPark.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
