using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    partial class ViewParkingForm
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
            lblSubtitle = new Label();
            pnlSlots = new Panel();
            btnSlot1 = new Button();
            btnSlot2 = new Button();
            btnSlot3 = new Button();
            btnSlot4 = new Button();
            btnSlot5 = new Button();
            btnSlot6 = new Button();
            btnSlot7 = new Button();
            btnSlot8 = new Button();
            btnSlot9 = new Button();
            btnSlot10 = new Button();
            btnSlot11 = new Button();
            btnSlot12 = new Button();
            btnSlot13 = new Button();
            btnSlot14 = new Button();
            btnSlot15 = new Button();
            btnSlot16 = new Button();
            btnSlot17 = new Button();
            btnSlot18 = new Button();
            btnSlot19 = new Button();
            btnSlot20 = new Button();
            pnlLegend = new Panel();
            pnlLegendAvailable = new Panel();
            lblLegendAvailable = new Label();
            pnlLegendOccupied = new Panel();
            lblLegendOccupied = new Label();
            pnlSummary = new Panel();
            lblSummaryAvailable = new Label();
            lblSummaryOccupied = new Label();
            lblAvailableCount = new Label();
            lblOccupiedCount = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            pnlSlots.SuspendLayout();
            pnlLegend.SuspendLayout();
            pnlSummary.SuspendLayout();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblTitle.Location = new Point(30, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "View Parking";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitle.Location = new Point(30, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(175, 19);
            lblSubtitle.TabIndex = 6;
            lblSubtitle.Text = "Click any slot for details";
            //
            // pnlSlots
            //
            pnlSlots.BackColor = Color.White;
            pnlSlots.Controls.Add(btnSlot1);
            pnlSlots.Controls.Add(btnSlot2);
            pnlSlots.Controls.Add(btnSlot3);
            pnlSlots.Controls.Add(btnSlot4);
            pnlSlots.Controls.Add(btnSlot5);
            pnlSlots.Controls.Add(btnSlot6);
            pnlSlots.Controls.Add(btnSlot7);
            pnlSlots.Controls.Add(btnSlot8);
            pnlSlots.Controls.Add(btnSlot9);
            pnlSlots.Controls.Add(btnSlot10);
            pnlSlots.Controls.Add(btnSlot11);
            pnlSlots.Controls.Add(btnSlot12);
            pnlSlots.Controls.Add(btnSlot13);
            pnlSlots.Controls.Add(btnSlot14);
            pnlSlots.Controls.Add(btnSlot15);
            pnlSlots.Controls.Add(btnSlot16);
            pnlSlots.Controls.Add(btnSlot17);
            pnlSlots.Controls.Add(btnSlot18);
            pnlSlots.Controls.Add(btnSlot19);
            pnlSlots.Controls.Add(btnSlot20);
            pnlSlots.Location = new Point(30, 75);
            pnlSlots.Name = "pnlSlots";
            pnlSlots.Size = new Size(740, 310);
            pnlSlots.TabIndex = 1;
            //
            // Slot buttons - Row 1
            //
            ConfigureSlotButton(btnSlot1, 15, 15, "B1");
            ConfigureSlotButton(btnSlot2, 160, 15, "B2");
            ConfigureSlotButton(btnSlot3, 305, 15, "B3");
            ConfigureSlotButton(btnSlot4, 450, 15, "B4");
            ConfigureSlotButton(btnSlot5, 595, 15, "B5");
            //
            // Row 2
            //
            ConfigureSlotButton(btnSlot6, 15, 85, "B6");
            ConfigureSlotButton(btnSlot7, 160, 85, "B7");
            ConfigureSlotButton(btnSlot8, 305, 85, "B8");
            ConfigureSlotButton(btnSlot9, 450, 85, "B9");
            ConfigureSlotButton(btnSlot10, 595, 85, "B10");
            //
            // Row 3
            //
            ConfigureSlotButton(btnSlot11, 15, 155, "B11");
            ConfigureSlotButton(btnSlot12, 160, 155, "B12");
            ConfigureSlotButton(btnSlot13, 305, 155, "B13");
            ConfigureSlotButton(btnSlot14, 450, 155, "B14");
            ConfigureSlotButton(btnSlot15, 595, 155, "B15");
            //
            // Row 4
            //
            ConfigureSlotButton(btnSlot16, 15, 225, "B16");
            ConfigureSlotButton(btnSlot17, 160, 225, "B17");
            ConfigureSlotButton(btnSlot18, 305, 225, "B18");
            ConfigureSlotButton(btnSlot19, 450, 225, "B19");
            ConfigureSlotButton(btnSlot20, 595, 225, "B20");
            //
            // pnlLegend
            //
            pnlLegend.BackColor = Color.White;
            pnlLegend.Controls.Add(lblLegendOccupied);
            pnlLegend.Controls.Add(pnlLegendOccupied);
            pnlLegend.Controls.Add(lblLegendAvailable);
            pnlLegend.Controls.Add(pnlLegendAvailable);
            pnlLegend.Location = new Point(30, 400);
            pnlLegend.Name = "pnlLegend";
            pnlLegend.Size = new Size(350, 35);
            pnlLegend.TabIndex = 2;
            //
            // pnlLegendAvailable
            //
            pnlLegendAvailable.BackColor = Color.FromArgb(39, 174, 96);
            pnlLegendAvailable.Location = new Point(15, 10);
            pnlLegendAvailable.Name = "pnlLegendAvailable";
            pnlLegendAvailable.Size = new Size(20, 15);
            pnlLegendAvailable.TabIndex = 0;
            //
            // lblLegendAvailable
            //
            lblLegendAvailable.AutoSize = true;
            lblLegendAvailable.Font = new Font("Segoe UI", 9.5F);
            lblLegendAvailable.ForeColor = Color.FromArgb(27, 42, 74);
            lblLegendAvailable.Location = new Point(42, 7);
            lblLegendAvailable.Name = "lblLegendAvailable";
            lblLegendAvailable.Size = new Size(64, 17);
            lblLegendAvailable.TabIndex = 1;
            lblLegendAvailable.Text = "Available";
            //
            // pnlLegendOccupied
            //
            pnlLegendOccupied.BackColor = Color.FromArgb(139, 0, 0);
            pnlLegendOccupied.Location = new Point(130, 10);
            pnlLegendOccupied.Name = "pnlLegendOccupied";
            pnlLegendOccupied.Size = new Size(20, 15);
            pnlLegendOccupied.TabIndex = 2;
            //
            // lblLegendOccupied
            //
            lblLegendOccupied.AutoSize = true;
            lblLegendOccupied.Font = new Font("Segoe UI", 9.5F);
            lblLegendOccupied.ForeColor = Color.FromArgb(27, 42, 74);
            lblLegendOccupied.Location = new Point(157, 7);
            lblLegendOccupied.Name = "lblLegendOccupied";
            lblLegendOccupied.Size = new Size(63, 17);
            lblLegendOccupied.TabIndex = 3;
            lblLegendOccupied.Text = "Occupied";
            //
            // pnlSummary
            //
            pnlSummary.BackColor = Color.White;
            pnlSummary.Controls.Add(lblOccupiedCount);
            pnlSummary.Controls.Add(lblSummaryOccupied);
            pnlSummary.Controls.Add(lblAvailableCount);
            pnlSummary.Controls.Add(lblSummaryAvailable);
            pnlSummary.Location = new Point(420, 400);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(350, 35);
            pnlSummary.TabIndex = 3;
            //
            // lblSummaryAvailable
            //
            lblSummaryAvailable.AutoSize = true;
            lblSummaryAvailable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummaryAvailable.ForeColor = Color.FromArgb(39, 174, 96);
            lblSummaryAvailable.Location = new Point(15, 8);
            lblSummaryAvailable.Name = "lblSummaryAvailable";
            lblSummaryAvailable.Size = new Size(73, 19);
            lblSummaryAvailable.TabIndex = 0;
            lblSummaryAvailable.Text = "Available:";
            //
            // lblAvailableCount
            //
            lblAvailableCount.AutoSize = true;
            lblAvailableCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvailableCount.ForeColor = Color.FromArgb(27, 42, 74);
            lblAvailableCount.Location = new Point(92, 8);
            lblAvailableCount.Name = "lblAvailableCount";
            lblAvailableCount.Size = new Size(20, 19);
            lblAvailableCount.TabIndex = 1;
            lblAvailableCount.Text = "0";
            //
            // lblSummaryOccupied
            //
            lblSummaryOccupied.AutoSize = true;
            lblSummaryOccupied.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummaryOccupied.ForeColor = Color.FromArgb(139, 0, 0);
            lblSummaryOccupied.Location = new Point(135, 8);
            lblSummaryOccupied.Name = "lblSummaryOccupied";
            lblSummaryOccupied.Size = new Size(72, 19);
            lblSummaryOccupied.TabIndex = 2;
            lblSummaryOccupied.Text = "Occupied:";
            //
            // lblOccupiedCount
            //
            lblOccupiedCount.AutoSize = true;
            lblOccupiedCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOccupiedCount.ForeColor = Color.FromArgb(27, 42, 74);
            lblOccupiedCount.Location = new Point(212, 8);
            lblOccupiedCount.Name = "lblOccupiedCount";
            lblOccupiedCount.Size = new Size(20, 19);
            lblOccupiedCount.TabIndex = 3;
            lblOccupiedCount.Text = "0";
            //
            // btnRefresh
            //
            btnRefresh.BackColor = Color.FromArgb(27, 42, 74);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(30, 460);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 38);
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
            btnClose.Location = new Point(185, 460);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 38);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // ViewParkingForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(800, 520);
            Controls.Add(lblSubtitle);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(pnlSummary);
            Controls.Add(pnlLegend);
            Controls.Add(pnlSlots);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewParkingForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Parking";
            pnlSlots.ResumeLayout(false);
            pnlLegend.ResumeLayout(false);
            pnlLegend.PerformLayout();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfigureSlotButton(Button btn, int x, int y, string text)
        {
            btn.BackColor = Color.FromArgb(39, 174, 96);
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.Location = new Point(x, y);
            btn.Name = "btn" + text;
            btn.Size = new Size(130, 55);
            btn.TabIndex = 0;
            btn.Text = text;
            btn.UseVisualStyleBackColor = false;
            btn.Click += SlotButton_Click;
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlSlots;
        private Button btnSlot1;
        private Button btnSlot2;
        private Button btnSlot3;
        private Button btnSlot4;
        private Button btnSlot5;
        private Button btnSlot6;
        private Button btnSlot7;
        private Button btnSlot8;
        private Button btnSlot9;
        private Button btnSlot10;
        private Button btnSlot11;
        private Button btnSlot12;
        private Button btnSlot13;
        private Button btnSlot14;
        private Button btnSlot15;
        private Button btnSlot16;
        private Button btnSlot17;
        private Button btnSlot18;
        private Button btnSlot19;
        private Button btnSlot20;
        private Panel pnlLegend;
        private Panel pnlLegendAvailable;
        private Label lblLegendAvailable;
        private Panel pnlLegendOccupied;
        private Label lblLegendOccupied;
        private Panel pnlSummary;
        private Label lblSummaryAvailable;
        private Label lblAvailableCount;
        private Label lblSummaryOccupied;
        private Label lblOccupiedCount;
        private Button btnRefresh;
        private Button btnClose;
    }
}
