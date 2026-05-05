using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    partial class ParkCarForm
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
            pnlForm = new Panel();
            lblPlateNumber = new Label();
            txtPlateNumber = new TextBox();
            lblOwnerName = new Label();
            txtOwnerName = new TextBox();
            lblCarColor = new Label();
            cboCarColor = new ComboBox();
            lblSlotNumber = new Label();
            cboSlotNumber = new ComboBox();
            btnPark = new Button();
            btnClear = new Button();
            btnClose = new Button();
            pnlForm.SuspendLayout();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblTitle.Location = new Point(40, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Park Car";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitle.Location = new Point(40, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(250, 19);
            lblSubtitle.TabIndex = 8;
            lblSubtitle.Text = "Enter vehicle details to assign a slot";
            //
            // pnlForm
            //
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(cboSlotNumber);
            pnlForm.Controls.Add(lblSlotNumber);
            pnlForm.Controls.Add(cboCarColor);
            pnlForm.Controls.Add(lblCarColor);
            pnlForm.Controls.Add(txtOwnerName);
            pnlForm.Controls.Add(lblOwnerName);
            pnlForm.Controls.Add(txtPlateNumber);
            pnlForm.Controls.Add(lblPlateNumber);
            pnlForm.Location = new Point(40, 95);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(500, 380);
            pnlForm.TabIndex = 1;
            //
            // lblPlateNumber
            //
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlateNumber.ForeColor = Color.FromArgb(27, 42, 74);
            lblPlateNumber.Location = new Point(20, 20);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(105, 19);
            lblPlateNumber.TabIndex = 0;
            lblPlateNumber.Text = "Plate Number";
            //
            // txtPlateNumber
            //
            txtPlateNumber.BackColor = Color.FromArgb(248, 249, 250);
            txtPlateNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPlateNumber.Font = new Font("Segoe UI", 13F);
            txtPlateNumber.ForeColor = Color.FromArgb(27, 42, 74);
            txtPlateNumber.Location = new Point(20, 45);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(460, 29);
            txtPlateNumber.TabIndex = 1;
            txtPlateNumber.KeyDown += txtPlateNumber_KeyDown;
            txtPlateNumber.TextAlign = HorizontalAlignment.Center;
            //
            // lblOwnerName
            //
            lblOwnerName.AutoSize = true;
            lblOwnerName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOwnerName.ForeColor = Color.FromArgb(27, 42, 74);
            lblOwnerName.Location = new Point(20, 95);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(91, 19);
            lblOwnerName.TabIndex = 2;
            lblOwnerName.Text = "Owner Name";
            //
            // txtOwnerName
            //
            txtOwnerName.BackColor = Color.FromArgb(248, 249, 250);
            txtOwnerName.BorderStyle = BorderStyle.FixedSingle;
            txtOwnerName.Font = new Font("Segoe UI", 13F);
            txtOwnerName.ForeColor = Color.FromArgb(27, 42, 74);
            txtOwnerName.Location = new Point(20, 120);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(460, 29);
            txtOwnerName.TabIndex = 2;
            txtOwnerName.TextAlign = HorizontalAlignment.Center;
            //
            // lblCarColor
            //
            lblCarColor.AutoSize = true;
            lblCarColor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCarColor.ForeColor = Color.FromArgb(27, 42, 74);
            lblCarColor.Location = new Point(20, 170);
            lblCarColor.Name = "lblCarColor";
            lblCarColor.Size = new Size(70, 19);
            lblCarColor.TabIndex = 4;
            lblCarColor.Text = "Car Color";
            //
            // cboCarColor
            //
            cboCarColor.BackColor = Color.FromArgb(248, 249, 250);
            cboCarColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarColor.FlatStyle = FlatStyle.Flat;
            cboCarColor.Font = new Font("Segoe UI", 11F);
            cboCarColor.ForeColor = Color.FromArgb(27, 42, 74);
            cboCarColor.FormattingEnabled = true;
            cboCarColor.Items.AddRange(new object[] { "Black", "White", "Silver", "Red", "Blue", "Green", "Gray", "Other" });
            cboCarColor.Location = new Point(20, 195);
            cboCarColor.Name = "cboCarColor";
            cboCarColor.Size = new Size(460, 28);
            cboCarColor.TabIndex = 3;
            //
            // lblSlotNumber
            //
            lblSlotNumber.AutoSize = true;
            lblSlotNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSlotNumber.ForeColor = Color.FromArgb(27, 42, 74);
            lblSlotNumber.Location = new Point(20, 245);
            lblSlotNumber.Name = "lblSlotNumber";
            lblSlotNumber.Size = new Size(83, 19);
            lblSlotNumber.TabIndex = 6;
            lblSlotNumber.Text = "Slot Number";
            //
            // cboSlotNumber
            //
            cboSlotNumber.BackColor = Color.FromArgb(248, 249, 250);
            cboSlotNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSlotNumber.FlatStyle = FlatStyle.Flat;
            cboSlotNumber.Font = new Font("Segoe UI", 11F);
            cboSlotNumber.ForeColor = Color.FromArgb(27, 42, 74);
            cboSlotNumber.FormattingEnabled = true;
            cboSlotNumber.Location = new Point(20, 270);
            cboSlotNumber.Name = "cboSlotNumber";
            cboSlotNumber.Size = new Size(460, 28);
            cboSlotNumber.TabIndex = 4;
            //
            // btnPark
            //
            btnPark.BackColor = Color.FromArgb(139, 0, 0);
            btnPark.Cursor = Cursors.Hand;
            btnPark.FlatAppearance.BorderSize = 0;
            btnPark.FlatStyle = FlatStyle.Flat;
            btnPark.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPark.ForeColor = Color.White;
            btnPark.Location = new Point(40, 500);
            btnPark.Name = "btnPark";
            btnPark.Size = new Size(180, 45);
            btnPark.TabIndex = 5;
            btnPark.Text = "Park Vehicle";
            btnPark.UseVisualStyleBackColor = false;
            btnPark.Click += btnPark_Click;
            //
            // btnClear
            //
            btnClear.BackColor = Color.FromArgb(108, 117, 125);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(235, 500);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 45);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.FromArgb(108, 117, 125);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(395, 500);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 45);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // ParkCarForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(580, 570);
            Controls.Add(lblSubtitle);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnPark);
            Controls.Add(pnlForm);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParkCarForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Park Car";
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlForm;
        private Label lblPlateNumber;
        private TextBox txtPlateNumber;
        private Label lblOwnerName;
        private TextBox txtOwnerName;
        private Label lblCarColor;
        private ComboBox cboCarColor;
        private Label lblSlotNumber;
        private ComboBox cboSlotNumber;
        private Button btnPark;
        private Button btnClear;
        private Button btnClose;
    }
}
