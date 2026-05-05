using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    partial class DashboardForm
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
            lblTitle = new Label();
            pnlCards = new Panel();
            pnlCardTotal = new Panel();
            lblCardTotalTitle = new Label();
            lblTotalSlots = new Label();
            pnlCardAvailable = new Panel();
            lblCardAvailableTitle = new Label();
            lblAvailableSlots = new Label();
            pnlCardOccupied = new Panel();
            lblCardOccupiedTitle = new Label();
            lblOccupiedSlots = new Label();
            pnlCardRevenue = new Panel();
            lblCardRevenueTitle = new Label();
            lblTodayRevenue = new Label();
            pnlOccupancy = new Panel();
            lblOccupancyTitle = new Label();
            pnlOccupancyBg = new Panel();
            pnlOccupancyFill = new Panel();
            lblOccupancyPercent = new Label();
            pnlActivity = new Panel();
            lblActivityTitle = new Label();
            lstRecentActivity = new ListBox();
            pnlCardExits = new Panel();
            lblCardExitsTitle = new Label();
            lblTodayExits = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            pnlCards.SuspendLayout();
            pnlCardTotal.SuspendLayout();
            pnlCardAvailable.SuspendLayout();
            pnlCardOccupied.SuspendLayout();
            pnlCardRevenue.SuspendLayout();
            pnlOccupancy.SuspendLayout();
            pnlActivity.SuspendLayout();
            pnlCardExits.SuspendLayout();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            //
            // pnlCards
            //
            pnlCards.Controls.Add(pnlCardExits);
            pnlCards.Controls.Add(pnlCardRevenue);
            pnlCards.Controls.Add(pnlCardOccupied);
            pnlCards.Controls.Add(pnlCardAvailable);
            pnlCards.Controls.Add(pnlCardTotal);
            pnlCards.Location = new Point(30, 80);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(880, 120);
            pnlCards.TabIndex = 1;
            //
            // pnlCardTotal
            //
            pnlCardTotal.BackColor = Color.FromArgb(27, 42, 74);
            pnlCardTotal.Controls.Add(lblTotalSlots);
            pnlCardTotal.Controls.Add(lblCardTotalTitle);
            pnlCardTotal.Location = new Point(0, 0);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Size = new Size(165, 120);
            pnlCardTotal.TabIndex = 0;
            //
            // lblCardTotalTitle
            //
            lblCardTotalTitle.AutoSize = true;
            lblCardTotalTitle.Font = new Font("Segoe UI", 9F);
            lblCardTotalTitle.ForeColor = Color.FromArgb(180, 190, 210);
            lblCardTotalTitle.Location = new Point(15, 15);
            lblCardTotalTitle.Name = "lblCardTotalTitle";
            lblCardTotalTitle.Size = new Size(67, 15);
            lblCardTotalTitle.TabIndex = 0;
            lblCardTotalTitle.Text = "Total Slots";
            //
            // lblTotalSlots
            //
            lblTotalSlots.AutoSize = true;
            lblTotalSlots.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalSlots.ForeColor = Color.White;
            lblTotalSlots.Location = new Point(15, 45);
            lblTotalSlots.Name = "lblTotalSlots";
            lblTotalSlots.Size = new Size(68, 65);
            lblTotalSlots.TabIndex = 1;
            lblTotalSlots.Text = "20";
            //
            // pnlCardAvailable
            //
            pnlCardAvailable.BackColor = Color.FromArgb(39, 174, 96);
            pnlCardAvailable.Controls.Add(lblAvailableSlots);
            pnlCardAvailable.Controls.Add(lblCardAvailableTitle);
            pnlCardAvailable.Location = new Point(178, 0);
            pnlCardAvailable.Name = "pnlCardAvailable";
            pnlCardAvailable.Size = new Size(165, 120);
            pnlCardAvailable.TabIndex = 1;
            //
            // lblCardAvailableTitle
            //
            lblCardAvailableTitle.AutoSize = true;
            lblCardAvailableTitle.Font = new Font("Segoe UI", 9F);
            lblCardAvailableTitle.ForeColor = Color.FromArgb(200, 240, 210);
            lblCardAvailableTitle.Location = new Point(15, 15);
            lblCardAvailableTitle.Name = "lblCardAvailableTitle";
            lblCardAvailableTitle.Size = new Size(74, 15);
            lblCardAvailableTitle.TabIndex = 0;
            lblCardAvailableTitle.Text = "Available";
            //
            // lblAvailableSlots
            //
            lblAvailableSlots.AutoSize = true;
            lblAvailableSlots.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblAvailableSlots.ForeColor = Color.White;
            lblAvailableSlots.Location = new Point(15, 45);
            lblAvailableSlots.Name = "lblAvailableSlots";
            lblAvailableSlots.Size = new Size(68, 65);
            lblAvailableSlots.TabIndex = 1;
            lblAvailableSlots.Text = "20";
            //
            // pnlCardOccupied
            //
            pnlCardOccupied.BackColor = Color.FromArgb(139, 0, 0);
            pnlCardOccupied.Controls.Add(lblOccupiedSlots);
            pnlCardOccupied.Controls.Add(lblCardOccupiedTitle);
            pnlCardOccupied.Location = new Point(356, 0);
            pnlCardOccupied.Name = "pnlCardOccupied";
            pnlCardOccupied.Size = new Size(165, 120);
            pnlCardOccupied.TabIndex = 2;
            //
            // lblCardOccupiedTitle
            //
            lblCardOccupiedTitle.AutoSize = true;
            lblCardOccupiedTitle.Font = new Font("Segoe UI", 9F);
            lblCardOccupiedTitle.ForeColor = Color.FromArgb(255, 200, 200);
            lblCardOccupiedTitle.Location = new Point(15, 15);
            lblCardOccupiedTitle.Name = "lblCardOccupiedTitle";
            lblCardOccupiedTitle.Size = new Size(67, 15);
            lblCardOccupiedTitle.TabIndex = 0;
            lblCardOccupiedTitle.Text = "Occupied";
            //
            // lblOccupiedSlots
            //
            lblOccupiedSlots.AutoSize = true;
            lblOccupiedSlots.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblOccupiedSlots.ForeColor = Color.White;
            lblOccupiedSlots.Location = new Point(15, 45);
            lblOccupiedSlots.Name = "lblOccupiedSlots";
            lblOccupiedSlots.Size = new Size(34, 65);
            lblOccupiedSlots.TabIndex = 1;
            lblOccupiedSlots.Text = "0";
            //
            // pnlCardRevenue
            //
            pnlCardRevenue.BackColor = Color.FromArgb(201, 162, 39);
            pnlCardRevenue.Controls.Add(lblTodayRevenue);
            pnlCardRevenue.Controls.Add(lblCardRevenueTitle);
            pnlCardRevenue.Location = new Point(534, 0);
            pnlCardRevenue.Name = "pnlCardRevenue";
            pnlCardRevenue.Size = new Size(165, 120);
            pnlCardRevenue.TabIndex = 3;
            //
            // lblCardRevenueTitle
            //
            lblCardRevenueTitle.AutoSize = true;
            lblCardRevenueTitle.Font = new Font("Segoe UI", 9F);
            lblCardRevenueTitle.ForeColor = Color.FromArgb(60, 50, 10);
            lblCardRevenueTitle.Location = new Point(15, 15);
            lblCardRevenueTitle.Name = "lblCardRevenueTitle";
            lblCardRevenueTitle.Size = new Size(90, 15);
            lblCardRevenueTitle.TabIndex = 0;
            lblCardRevenueTitle.Text = "Today's Revenue";
            //
            // lblTodayRevenue
            //
            lblTodayRevenue.AutoSize = true;
            lblTodayRevenue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTodayRevenue.ForeColor = Color.White;
            lblTodayRevenue.Location = new Point(15, 50);
            lblTodayRevenue.Name = "lblTodayRevenue";
            lblTodayRevenue.Size = new Size(100, 45);
            lblTodayRevenue.TabIndex = 1;
            lblTodayRevenue.Text = "EGP 0";
            //
            // pnlCardExits
            //
            pnlCardExits.BackColor = Color.FromArgb(52, 73, 94);
            pnlCardExits.Controls.Add(lblTodayExits);
            pnlCardExits.Controls.Add(lblCardExitsTitle);
            pnlCardExits.Location = new Point(712, 0);
            pnlCardExits.Name = "pnlCardExits";
            pnlCardExits.Size = new Size(165, 120);
            pnlCardExits.TabIndex = 4;
            //
            // lblCardExitsTitle
            //
            lblCardExitsTitle.AutoSize = true;
            lblCardExitsTitle.Font = new Font("Segoe UI", 9F);
            lblCardExitsTitle.ForeColor = Color.FromArgb(180, 190, 210);
            lblCardExitsTitle.Location = new Point(15, 15);
            lblCardExitsTitle.Name = "lblCardExitsTitle";
            lblCardExitsTitle.Size = new Size(82, 15);
            lblCardExitsTitle.TabIndex = 0;
            lblCardExitsTitle.Text = "Today's Exits";
            //
            // lblTodayExits
            //
            lblTodayExits.AutoSize = true;
            lblTodayExits.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTodayExits.ForeColor = Color.White;
            lblTodayExits.Location = new Point(15, 45);
            lblTodayExits.Name = "lblTodayExits";
            lblTodayExits.Size = new Size(34, 65);
            lblTodayExits.TabIndex = 1;
            lblTodayExits.Text = "0";
            //
            // pnlOccupancy
            //
            pnlOccupancy.BackColor = Color.White;
            pnlOccupancy.Controls.Add(lblOccupancySummary);
            pnlOccupancy.Controls.Add(lblOccupancyPercent);
            pnlOccupancy.Controls.Add(pnlOccupancyFill);
            pnlOccupancy.Controls.Add(pnlOccupancyBg);
            pnlOccupancy.Controls.Add(lblOccupancyTitle);
            pnlOccupancy.Location = new Point(30, 220);
            pnlOccupancy.Name = "pnlOccupancy";
            pnlOccupancy.Size = new Size(440, 115);
            pnlOccupancy.TabIndex = 2;
            //
            // lblOccupancyTitle
            //
            lblOccupancyTitle.AutoSize = true;
            lblOccupancyTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblOccupancyTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblOccupancyTitle.Location = new Point(15, 10);
            lblOccupancyTitle.Name = "lblOccupancyTitle";
            lblOccupancyTitle.Size = new Size(130, 20);
            lblOccupancyTitle.TabIndex = 0;
            lblOccupancyTitle.Text = "Occupancy Level";
            //
            // pnlOccupancyBg
            //
            pnlOccupancyBg.BackColor = Color.FromArgb(230, 230, 230);
            pnlOccupancyBg.Location = new Point(15, 40);
            pnlOccupancyBg.Name = "pnlOccupancyBg";
            pnlOccupancyBg.Size = new Size(410, 25);
            pnlOccupancyBg.TabIndex = 1;
            //
            // pnlOccupancyFill
            //
            pnlOccupancyFill.BackColor = Color.FromArgb(39, 174, 96);
            pnlOccupancyFill.Location = new Point(15, 40);
            pnlOccupancyFill.Name = "pnlOccupancyFill";
            pnlOccupancyFill.Size = new Size(0, 25);
            pnlOccupancyFill.TabIndex = 2;
            //
            // lblOccupancyPercent
            //
            lblOccupancyPercent.AutoSize = true;
            lblOccupancyPercent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOccupancyPercent.ForeColor = Color.FromArgb(108, 117, 125);
            lblOccupancyPercent.Location = new Point(15, 70);
            lblOccupancyPercent.Name = "lblOccupancyPercent";
            lblOccupancyPercent.Size = new Size(85, 17);
            lblOccupancyPercent.TabIndex = 3;
            lblOccupancyPercent.Text = "0% Occupancy";
            //
            // lblOccupancySummary
            //
            lblOccupancySummary = new Label();
            lblOccupancySummary.AutoSize = true;
            lblOccupancySummary.Font = new Font("Segoe UI", 9F);
            lblOccupancySummary.ForeColor = Color.FromArgb(108, 117, 125);
            lblOccupancySummary.Location = new Point(15, 90);
            lblOccupancySummary.Name = "lblOccupancySummary";
            lblOccupancySummary.Size = new Size(140, 15);
            lblOccupancySummary.TabIndex = 4;
            lblOccupancySummary.Text = "0 of 20 slots occupied";
            //
            // pnlActivity
            //
            pnlActivity.BackColor = Color.White;
            pnlActivity.Controls.Add(lstRecentActivity);
            pnlActivity.Controls.Add(lblActivityTitle);
            pnlActivity.Location = new Point(490, 220);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new Size(420, 350);
            pnlActivity.TabIndex = 3;
            //
            // lblActivityTitle
            //
            lblActivityTitle.AutoSize = true;
            lblActivityTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblActivityTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblActivityTitle.Location = new Point(15, 10);
            lblActivityTitle.Name = "lblActivityTitle";
            lblActivityTitle.Size = new Size(116, 20);
            lblActivityTitle.TabIndex = 0;
            lblActivityTitle.Text = "Currently Parked";
            //
            // lstRecentActivity
            //
            lstRecentActivity.BorderStyle = BorderStyle.None;
            lstRecentActivity.Font = new Font("Segoe UI", 10F);
            lstRecentActivity.ForeColor = Color.FromArgb(27, 42, 74);
            lstRecentActivity.FormattingEnabled = true;
            lstRecentActivity.ItemHeight = 18;
            lstRecentActivity.Location = new Point(15, 40);
            lstRecentActivity.Name = "lstRecentActivity";
            lstRecentActivity.Size = new Size(390, 298);
            lstRecentActivity.TabIndex = 1;
            //
            // btnRefresh
            //
            btnRefresh.BackColor = Color.FromArgb(27, 42, 74);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(30, 580);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 38);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.FromArgb(108, 117, 125);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(165, 580);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 38);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // DashboardForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(940, 640);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(pnlActivity);
            Controls.Add(pnlOccupancy);
            Controls.Add(pnlCards);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DashboardForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dashboard";
            pnlCards.ResumeLayout(false);
            pnlCardTotal.ResumeLayout(false);
            pnlCardTotal.PerformLayout();
            pnlCardAvailable.ResumeLayout(false);
            pnlCardAvailable.PerformLayout();
            pnlCardOccupied.ResumeLayout(false);
            pnlCardOccupied.PerformLayout();
            pnlCardRevenue.ResumeLayout(false);
            pnlCardRevenue.PerformLayout();
            pnlOccupancy.ResumeLayout(false);
            pnlOccupancy.PerformLayout();
            pnlActivity.ResumeLayout(false);
            pnlCardExits.ResumeLayout(false);
            pnlCardExits.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlCards;
        private Panel pnlCardTotal;
        private Label lblCardTotalTitle;
        private Label lblTotalSlots;
        private Panel pnlCardAvailable;
        private Label lblCardAvailableTitle;
        private Label lblAvailableSlots;
        private Panel pnlCardOccupied;
        private Label lblCardOccupiedTitle;
        private Label lblOccupiedSlots;
        private Panel pnlCardRevenue;
        private Label lblCardRevenueTitle;
        private Label lblTodayRevenue;
        private Panel pnlOccupancy;
        private Label lblOccupancyTitle;
        private Panel pnlOccupancyBg;
        private Panel pnlOccupancyFill;
        private Label lblOccupancyPercent;
        private Label lblOccupancySummary;
        private Panel pnlActivity;
        private Label lblActivityTitle;
        private ListBox lstRecentActivity;
        private Panel pnlCardExits;
        private Label lblCardExitsTitle;
        private Label lblTodayExits;
        private Button btnRefresh;
        private Button btnClose;
    }
}
