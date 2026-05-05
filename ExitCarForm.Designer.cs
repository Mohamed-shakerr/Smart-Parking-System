using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    partial class ExitCarForm
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
            lblPlateLabel = new Label();
            txtPlateNumber = new TextBox();
            btnSearch = new Button();
            pnlResult = new Panel();
            lblResultPlate = new Label();
            lblResultOwner = new Label();
            lblResultColor = new Label();
            lblResultSlot = new Label();
            lblResultDuration = new Label();
            lblResultFee = new Label();
            lblResultEntry = new Label();
            lblResultHeader = new Label();
            btnExitCar = new Button();
            btnClose = new Button();
            pnlResult.SuspendLayout();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblTitle.Location = new Point(40, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(145, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Exit Car";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitle.Location = new Point(40, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(280, 19);
            lblSubtitle.TabIndex = 8;
            lblSubtitle.Text = "Search by plate number to process vehicle exit";
            //
            // lblPlateLabel
            //
            lblPlateLabel.AutoSize = true;
            lblPlateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlateLabel.ForeColor = Color.FromArgb(27, 42, 74);
            lblPlateLabel.Location = new Point(40, 100);
            lblPlateLabel.Name = "lblPlateLabel";
            lblPlateLabel.Size = new Size(105, 19);
            lblPlateLabel.TabIndex = 1;
            lblPlateLabel.Text = "Plate Number";
            //
            // txtPlateNumber
            //
            txtPlateNumber.BackColor = Color.FromArgb(248, 249, 250);
            txtPlateNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPlateNumber.Font = new Font("Segoe UI", 12F);
            txtPlateNumber.ForeColor = Color.FromArgb(27, 42, 74);
            txtPlateNumber.Location = new Point(40, 125);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(340, 29);
            txtPlateNumber.TabIndex = 1;
            txtPlateNumber.TextAlign = HorizontalAlignment.Center;
            txtPlateNumber.KeyDown += txtPlateNumber_KeyDown;
            //
            // btnSearch
            //
            btnSearch.BackColor = Color.FromArgb(27, 42, 74);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(395, 123);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            //
            // pnlResult
            //
            pnlResult.BackColor = Color.White;
            pnlResult.Controls.Add(lblResultEntry);
            pnlResult.Controls.Add(lblResultFee);
            pnlResult.Controls.Add(lblResultDuration);
            pnlResult.Controls.Add(lblResultSlot);
            pnlResult.Controls.Add(lblResultColor);
            pnlResult.Controls.Add(lblResultOwner);
            pnlResult.Controls.Add(lblResultPlate);
            pnlResult.Controls.Add(lblResultHeader);
            pnlResult.Location = new Point(40, 180);
            pnlResult.Name = "pnlResult";
            pnlResult.Size = new Size(470, 240);
            pnlResult.TabIndex = 4;
            pnlResult.Visible = false;
            //
            // lblResultHeader
            //
            lblResultHeader.AutoSize = true;
            lblResultHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResultHeader.ForeColor = Color.FromArgb(139, 0, 0);
            lblResultHeader.Location = new Point(15, 10);
            lblResultHeader.Name = "lblResultHeader";
            lblResultHeader.Size = new Size(106, 21);
            lblResultHeader.TabIndex = 0;
            lblResultHeader.Text = "Vehicle Info";
            //
            // lblResultPlate
            //
            lblResultPlate.AutoSize = true;
            lblResultPlate.Font = new Font("Segoe UI", 11F);
            lblResultPlate.ForeColor = Color.FromArgb(27, 42, 74);
            lblResultPlate.Location = new Point(15, 45);
            lblResultPlate.Name = "lblResultPlate";
            lblResultPlate.Size = new Size(70, 20);
            lblResultPlate.TabIndex = 1;
            lblResultPlate.Text = "Plate: -";
            //
            // lblResultOwner
            //
            lblResultOwner.AutoSize = true;
            lblResultOwner.Font = new Font("Segoe UI", 11F);
            lblResultOwner.ForeColor = Color.FromArgb(27, 42, 74);
            lblResultOwner.Location = new Point(15, 75);
            lblResultOwner.Name = "lblResultOwner";
            lblResultOwner.Size = new Size(70, 20);
            lblResultOwner.TabIndex = 2;
            lblResultOwner.Text = "Owner: -";
            //
            // lblResultColor
            //
            lblResultColor.AutoSize = true;
            lblResultColor.Font = new Font("Segoe UI", 11F);
            lblResultColor.ForeColor = Color.FromArgb(27, 42, 74);
            lblResultColor.Location = new Point(15, 105);
            lblResultColor.Name = "lblResultColor";
            lblResultColor.Size = new Size(70, 20);
            lblResultColor.TabIndex = 3;
            lblResultColor.Text = "Color: -";
            //
            // lblResultSlot
            //
            lblResultSlot.AutoSize = true;
            lblResultSlot.Font = new Font("Segoe UI", 11F);
            lblResultSlot.ForeColor = Color.FromArgb(27, 42, 74);
            lblResultSlot.Location = new Point(250, 45);
            lblResultSlot.Name = "lblResultSlot";
            lblResultSlot.Size = new Size(70, 20);
            lblResultSlot.TabIndex = 4;
            lblResultSlot.Text = "Slot: -";
            //
            // lblResultDuration
            //
            lblResultDuration.AutoSize = true;
            lblResultDuration.Font = new Font("Segoe UI", 11F);
            lblResultDuration.ForeColor = Color.FromArgb(27, 42, 74);
            lblResultDuration.Location = new Point(250, 75);
            lblResultDuration.Name = "lblResultDuration";
            lblResultDuration.Size = new Size(85, 20);
            lblResultDuration.TabIndex = 5;
            lblResultDuration.Text = "Duration: -";
            //
            // lblResultFee
            //
            lblResultFee.AutoSize = true;
            lblResultFee.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResultFee.ForeColor = Color.FromArgb(139, 0, 0);
            lblResultFee.Location = new Point(15, 170);
            lblResultFee.Name = "lblResultFee";
            lblResultFee.Size = new Size(85, 25);
            lblResultFee.TabIndex = 6;
            lblResultFee.Text = "Fee: EGP 0";
            //
            // lblResultEntry
            //
            lblResultEntry.AutoSize = true;
            lblResultEntry.Font = new Font("Segoe UI", 11F);
            lblResultEntry.ForeColor = Color.FromArgb(27, 42, 74);
            lblResultEntry.Location = new Point(250, 105);
            lblResultEntry.Name = "lblResultEntry";
            lblResultEntry.Size = new Size(90, 20);
            lblResultEntry.TabIndex = 7;
            lblResultEntry.Text = "Entry: -";
            //
            // btnExitCar
            //
            btnExitCar.BackColor = Color.FromArgb(139, 0, 0);
            btnExitCar.Cursor = Cursors.Hand;
            btnExitCar.Enabled = false;
            btnExitCar.FlatAppearance.BorderSize = 0;
            btnExitCar.FlatStyle = FlatStyle.Flat;
            btnExitCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExitCar.ForeColor = Color.White;
            btnExitCar.Location = new Point(40, 450);
            btnExitCar.Name = "btnExitCar";
            btnExitCar.Size = new Size(220, 45);
            btnExitCar.TabIndex = 3;
            btnExitCar.Text = "Confirm Exit";
            btnExitCar.UseVisualStyleBackColor = false;
            btnExitCar.Click += btnExitCar_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.FromArgb(108, 117, 125);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(275, 450);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 45);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // ExitCarForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(560, 510);
            Controls.Add(lblSubtitle);
            Controls.Add(btnClose);
            Controls.Add(btnExitCar);
            Controls.Add(pnlResult);
            Controls.Add(btnSearch);
            Controls.Add(txtPlateNumber);
            Controls.Add(lblPlateLabel);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExitCarForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Exit Car";
            pnlResult.ResumeLayout(false);
            pnlResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblPlateLabel;
        private TextBox txtPlateNumber;
        private Button btnSearch;
        private Panel pnlResult;
        private Label lblResultPlate;
        private Label lblResultOwner;
        private Label lblResultColor;
        private Label lblResultSlot;
        private Label lblResultDuration;
        private Label lblResultFee;
        private Label lblResultEntry;
        private Label lblResultHeader;
        private Button btnExitCar;
        private Button btnClose;
    }
}
