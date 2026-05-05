using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    public partial class HomeForm : Form
    {
        private ParkingManager manager;
        private System.Windows.Forms.Timer clockTimer;

        public HomeForm()
        {
            InitializeComponent();
            manager = new ParkingManager();
            UpdateStatusBar();
            StartClock();
        }

        private void StartClock()
        {
            UpdateClock();
            clockTimer = new System.Windows.Forms.Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += (s, e) => UpdateClock();
            clockTimer.Start();
        }

        private void UpdateClock()
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy\nhh:mm:ss tt");
        }

        private void UpdateStatusBar()
        {
            lblStatusAvailable.Text = $"Available: {manager.GetAvailableCount()}";
            lblStatusOccupied.Text = $"Occupied: {manager.GetOccupiedCount()}";
            lblStatusTotal.Text = $"Total: {manager.TotalSlots}";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            using (DashboardForm dashboard = new DashboardForm(manager))
            {
                dashboard.ShowDialog(this);
            }
            UpdateStatusBar();
        }

        private void btnParkCar_Click(object sender, EventArgs e)
        {
            using (ParkCarForm parkCar = new ParkCarForm(manager))
            {
                parkCar.ShowDialog(this);
            }
            UpdateStatusBar();
        }

        private void btnExitCar_Click(object sender, EventArgs e)
        {
            using (ExitCarForm exitCar = new ExitCarForm(manager))
            {
                exitCar.ShowDialog(this);
            }
            UpdateStatusBar();
        }

        private void btnViewParking_Click(object sender, EventArgs e)
        {
            using (ViewParkingForm viewParking = new ViewParkingForm(manager))
            {
                viewParking.ShowDialog(this);
            }
            UpdateStatusBar();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            using (ReportsForm reports = new ReportsForm(manager))
            {
                reports.ShowDialog(this);
            }
            UpdateStatusBar();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (AboutDialog about = new AboutDialog())
            {
                about.ShowDialog(this);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                clockTimer?.Stop();
                clockTimer?.Dispose();
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            clockTimer?.Stop();
            clockTimer?.Dispose();

            // Only exit application if no visible forms remain
            bool hasVisibleForm = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Visible)
                {
                    hasVisibleForm = true;
                    break;
                }
            }
            if (!hasVisibleForm)
            {
                Application.Exit();
            }
        }

        private void HomeForm_Shown(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }
    }
}
