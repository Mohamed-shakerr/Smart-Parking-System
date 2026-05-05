using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class ReportsForm : Form
    {
        private ParkingManager manager;

        public ReportsForm(ParkingManager mgr)
        {
            InitializeComponent();
            manager = mgr;
            LoadCurrentReport();
        }

        private void LoadCurrentReport()
        {
            dgvCurrent.Rows.Clear();
            ParkingSlot[] slots = manager.GetAllSlots();

            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].Status == SlotStatus.Occupied)
                {
                    TimeSpan duration = slots[i].ParkedCar!.GetParkingDuration();
                    double estimatedFee = Math.Ceiling(duration.TotalHours) * ParkingManager.HOURLY_RATE;
                    if (estimatedFee < ParkingManager.MINIMUM_FEE) estimatedFee = ParkingManager.MINIMUM_FEE;

                    dgvCurrent.Rows.Add(
                        slots[i].ParkedCar.PlateNumber,
                        slots[i].ParkedCar.Owner,
                        $"B{slots[i].SlotNumber}",
                        slots[i].ParkedCar.EntryTime.ToString("HH:mm:ss"),
                        $"EGP {estimatedFee:F2}"
                    );
                }
            }

            lblCurrentCount.Text = $"Currently Parked: {manager.GetOccupiedCount()} vehicles";
        }

        private void LoadHistoryReport()
        {
            dgvHistory.Rows.Clear();
            List<TransactionRecord> history = manager.GetTransactionHistory();

            // Show most recent first
            for (int i = history.Count - 1; i >= 0; i--)
            {
                var record = history[i];
                dgvHistory.Rows.Add(
                    record.PlateNumber,
                    record.Owner,
                    $"B{record.SlotNumber}",
                    record.EntryTime.ToString("HH:mm:ss"),
                    record.ExitTime.ToString("HH:mm:ss"),
                    $"EGP {record.Fee:F2}"
                );
            }

            lblHistoryCount.Text = $"Total Transactions: {history.Count} | Revenue: EGP {manager.TotalRevenue:F2}";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                LoadHistoryReport();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
                LoadCurrentReport();
            else
                LoadHistoryReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
