using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class DashboardForm : Form
    {
        private ParkingManager manager;

        public DashboardForm(ParkingManager mgr)
        {
            InitializeComponent();
            manager = mgr;
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            int available = manager.GetAvailableCount();
            int occupied = manager.GetOccupiedCount();
            int total = manager.TotalSlots;
            double todayRevenue = manager.GetTodaysRevenue();
            int todayExits = manager.GetTodaysTransactions().Count;

            // Update stat cards
            lblTotalSlots.Text = total.ToString();
            lblAvailableSlots.Text = available.ToString();
            lblOccupiedSlots.Text = occupied.ToString();
            lblTodayRevenue.Text = $"EGP {todayRevenue:F0}";
            lblTodayExits.Text = todayExits.ToString();

            // Update occupancy bar
            double percentage = total > 0 ? (double)occupied / total * 100 : 0;
            lblOccupancyPercent.Text = $"{percentage:F0}% Occupancy";
            pnlOccupancyFill.Width = (int)(pnlOccupancyBg.Width * percentage / 100);

            if (percentage >= 90)
                pnlOccupancyFill.BackColor = Color.FromArgb(231, 76, 60);
            else if (percentage >= 70)
                pnlOccupancyFill.BackColor = Color.FromArgb(243, 156, 18);
            else
                pnlOccupancyFill.BackColor = Color.FromArgb(39, 174, 96);

            // Update recent activity with owner info
            lstRecentActivity.Items.Clear();
            var slots = manager.GetAllSlots();
            foreach (var slot in slots)
            {
                if (slot.Status == SlotStatus.Occupied)
                {
                    TimeSpan duration = slot.ParkedCar!.GetParkingDuration();
                    string durationStr = duration.TotalHours >= 1
                        ? $"{(int)duration.TotalHours}h {duration.Minutes}m"
                        : $"{duration.Minutes}m";
                    lstRecentActivity.Items.Add(
                        $"B{slot.SlotNumber} | {slot.ParkedCar.PlateNumber} | {slot.ParkedCar.Owner} | {durationStr}");
                }
            }

            if (lstRecentActivity.Items.Count == 0)
            {
                lstRecentActivity.Items.Add("No vehicles currently parked.");
            }

            // Update summary line
            lblOccupancySummary.Text = $"{occupied} of {total} slots occupied | {available} available";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }
    }
}
