using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            lblNavTitle = new Label();
            pnlNavSeparator = new Panel();
            btnDashboard = new Button();
            btnParkCar = new Button();
            btnExitCar = new Button();
            btnViewParking = new Button();
            btnReports = new Button();
            btnAbout = new Button();
            pnlNavFooter = new Panel();
            lblNavFooter = new Label();
            pnlLogoutSeparator = new Panel();
            btnLogout = new Button();
            pnlContent = new Panel();
            lblWelcome = new Label();
            lblWelcomeSubtitle = new Label();
            pnlStatsBar = new Panel();
            lblStatusTotal = new Label();
            lblStatusOccupied = new Label();
            lblStatusAvailable = new Label();
            lblDateTime = new Label();
            pnlSidebar.SuspendLayout();
            pnlNavFooter.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlStatsBar.SuspendLayout();
            SuspendLayout();
            //
            // pnlSidebar
            //
            pnlSidebar.BackColor = Color.FromArgb(27, 42, 74);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(pnlLogoutSeparator);
            pnlSidebar.Controls.Add(pnlNavFooter);
            pnlSidebar.Controls.Add(btnAbout);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnViewParking);
            pnlSidebar.Controls.Add(btnExitCar);
            pnlSidebar.Controls.Add(btnParkCar);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(pnlNavSeparator);
            pnlSidebar.Controls.Add(lblNavTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 750);
            pnlSidebar.TabIndex = 0;
            //
            // lblNavTitle
            //
            lblNavTitle.AutoSize = true;
            lblNavTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNavTitle.ForeColor = Color.White;
            lblNavTitle.Location = new Point(20, 25);
            lblNavTitle.Name = "lblNavTitle";
            lblNavTitle.Size = new Size(113, 25);
            lblNavTitle.TabIndex = 0;
            lblNavTitle.Text = "Smart Parking";
            //
            // pnlNavSeparator
            //
            pnlNavSeparator.BackColor = Color.FromArgb(50, 70, 110);
            pnlNavSeparator.Location = new Point(20, 60);
            pnlNavSeparator.Name = "pnlNavSeparator";
            pnlNavSeparator.Size = new Size(210, 1);
            pnlNavSeparator.TabIndex = 1;
            //
            // btnDashboard
            //
            ConfigureNavButton(btnDashboard, "Dashboard", 75, 1);
            btnDashboard.Click += btnDashboard_Click;
            //
            // btnParkCar
            //
            ConfigureNavButton(btnParkCar, "Park Car", 123, 2);
            btnParkCar.Click += btnParkCar_Click;
            //
            // btnExitCar
            //
            ConfigureNavButton(btnExitCar, "Exit Car", 171, 3);
            btnExitCar.Click += btnExitCar_Click;
            //
            // btnViewParking
            //
            ConfigureNavButton(btnViewParking, "View Parking", 219, 4);
            btnViewParking.Click += btnViewParking_Click;
            //
            // btnReports
            //
            ConfigureNavButton(btnReports, "Reports", 267, 5);
            btnReports.Click += btnReports_Click;
            //
            // btnAbout
            //
            ConfigureNavButton(btnAbout, "About", 315, 6);
            btnAbout.Click += btnAbout_Click;
            //
            // pnlLogoutSeparator
            //
            pnlLogoutSeparator.BackColor = Color.FromArgb(50, 70, 110);
            pnlLogoutSeparator.Location = new Point(20, 635);
            pnlLogoutSeparator.Name = "pnlLogoutSeparator";
            pnlLogoutSeparator.Size = new Size(210, 1);
            pnlLogoutSeparator.TabIndex = 10;
            //
            // pnlNavFooter
            //
            pnlNavFooter.Controls.Add(lblNavFooter);
            pnlNavFooter.Location = new Point(0, 541);
            pnlNavFooter.Name = "pnlNavFooter";
            pnlNavFooter.Size = new Size(250, 60);
            pnlNavFooter.TabIndex = 9;
            //
            // lblNavFooter
            //
            lblNavFooter.AutoSize = true;
            lblNavFooter.Font = new Font("Segoe UI", 8.5F);
            lblNavFooter.ForeColor = Color.FromArgb(120, 140, 170);
            lblNavFooter.Location = new Point(20, 5);
            lblNavFooter.Name = "lblNavFooter";
            lblNavFooter.Size = new Size(180, 30);
            lblNavFooter.TabIndex = 0;
            lblNavFooter.Text = "New Mansoura University\nFaculty of CSE";
            //
            // btnLogout
            //
            btnLogout.Anchor = AnchorStyles.Bottom;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 0, 0);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(255, 200, 200);
            btnLogout.Location = new Point(0, 650);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(250, 48);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "     Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            //
            // pnlContent
            //
            pnlContent.BackColor = Color.FromArgb(248, 249, 250);
            pnlContent.Controls.Add(lblDateTime);
            pnlContent.Controls.Add(pnlStatsBar);
            pnlContent.Controls.Add(lblWelcomeSubtitle);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(250, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1020, 750);
            pnlContent.TabIndex = 1;
            //
            // lblWelcome
            //
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(27, 42, 74);
            lblWelcome.Location = new Point(150, 220);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(615, 65);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to NMU Parking";
            //
            // lblWelcomeSubtitle
            //
            lblWelcomeSubtitle.AutoSize = true;
            lblWelcomeSubtitle.Font = new Font("Segoe UI", 14F);
            lblWelcomeSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblWelcomeSubtitle.Location = new Point(210, 295);
            lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            lblWelcomeSubtitle.Size = new Size(530, 25);
            lblWelcomeSubtitle.TabIndex = 1;
            lblWelcomeSubtitle.Text = "Smart Parking Management System - New Mansoura University";
            //
            // lblDateTime
            //
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 11F);
            lblDateTime.ForeColor = Color.FromArgb(108, 117, 125);
            lblDateTime.Location = new Point(370, 340);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(100, 40);
            lblDateTime.TabIndex = 3;
            lblDateTime.Text = "Loading...";
            lblDateTime.TextAlign = ContentAlignment.MiddleCenter;
            //
            // pnlStatsBar
            //
            pnlStatsBar.BackColor = Color.White;
            pnlStatsBar.Controls.Add(lblStatusAvailable);
            pnlStatsBar.Controls.Add(lblStatusOccupied);
            pnlStatsBar.Controls.Add(lblStatusTotal);
            pnlStatsBar.Location = new Point(160, 430);
            pnlStatsBar.Name = "pnlStatsBar";
            pnlStatsBar.Size = new Size(700, 60);
            pnlStatsBar.TabIndex = 2;
            //
            // lblStatusTotal
            //
            lblStatusTotal.AutoSize = true;
            lblStatusTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatusTotal.ForeColor = Color.FromArgb(27, 42, 74);
            lblStatusTotal.Location = new Point(500, 20);
            lblStatusTotal.Name = "lblStatusTotal";
            lblStatusTotal.Size = new Size(75, 21);
            lblStatusTotal.TabIndex = 2;
            lblStatusTotal.Text = "Total: 20";
            //
            // lblStatusOccupied
            //
            lblStatusOccupied.AutoSize = true;
            lblStatusOccupied.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatusOccupied.ForeColor = Color.FromArgb(139, 0, 0);
            lblStatusOccupied.Location = new Point(270, 20);
            lblStatusOccupied.Name = "lblStatusOccupied";
            lblStatusOccupied.Size = new Size(95, 21);
            lblStatusOccupied.TabIndex = 1;
            lblStatusOccupied.Text = "Occupied: 0";
            //
            // lblStatusAvailable
            //
            lblStatusAvailable.AutoSize = true;
            lblStatusAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatusAvailable.ForeColor = Color.FromArgb(39, 174, 96);
            lblStatusAvailable.Location = new Point(30, 20);
            lblStatusAvailable.Name = "lblStatusAvailable";
            lblStatusAvailable.Size = new Size(105, 21);
            lblStatusAvailable.TabIndex = 0;
            lblStatusAvailable.Text = "Available: 20";
            //
            // HomeForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1270, 750);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            DoubleBuffered = true;
            Name = "HomeForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NMU Smart Parking - Home";
            WindowState = FormWindowState.Maximized;
            FormClosed += HomeForm_FormClosed;
            Shown += HomeForm_Shown;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlNavFooter.ResumeLayout(false);
            pnlNavFooter.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlStatsBar.ResumeLayout(false);
            pnlStatsBar.PerformLayout();
            ResumeLayout(false);
        }

        private void ConfigureNavButton(Button btn, string text, int y, int tabIndex)
        {
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 55, 90);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 50, 85);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 11F);
            btn.ForeColor = Color.White;
            btn.Location = new Point(0, y);
            btn.Name = "btn" + text.Replace(" ", "");
            btn.Padding = new Padding(20, 0, 0, 0);
            btn.Size = new Size(250, 48);
            btn.TabIndex = tabIndex;
            btn.Text = "     " + text;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = true;
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblNavTitle;
        private Panel pnlNavSeparator;
        private Button btnDashboard;
        private Button btnParkCar;
        private Button btnExitCar;
        private Button btnViewParking;
        private Button btnReports;
        private Button btnAbout;
        private Panel pnlNavFooter;
        private Label lblNavFooter;
        private Panel pnlLogoutSeparator;
        private Button btnLogout;
        private Panel pnlContent;
        private Label lblWelcome;
        private Label lblWelcomeSubtitle;
        private Panel pnlStatsBar;
        private Label lblStatusAvailable;
        private Label lblStatusOccupied;
        private Label lblStatusTotal;
        private Label lblDateTime;
    }
}
