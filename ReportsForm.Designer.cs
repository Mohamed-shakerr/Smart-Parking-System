using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    partial class ReportsForm
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
            tabControl = new TabControl();
            tabCurrent = new TabPage();
            dgvCurrent = new DataGridView();
            colCurrentPlate = new DataGridViewTextBoxColumn();
            colCurrentOwner = new DataGridViewTextBoxColumn();
            colCurrentSlot = new DataGridViewTextBoxColumn();
            colCurrentTimeIn = new DataGridViewTextBoxColumn();
            colCurrentFee = new DataGridViewTextBoxColumn();
            lblCurrentCount = new Label();
            tabHistory = new TabPage();
            dgvHistory = new DataGridView();
            colHistoryPlate = new DataGridViewTextBoxColumn();
            colHistoryOwner = new DataGridViewTextBoxColumn();
            colHistorySlot = new DataGridViewTextBoxColumn();
            colHistoryTimeIn = new DataGridViewTextBoxColumn();
            colHistoryTimeOut = new DataGridViewTextBoxColumn();
            colHistoryFee = new DataGridViewTextBoxColumn();
            lblHistoryCount = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            tabControl.SuspendLayout();
            tabCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrent).BeginInit();
            tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblTitle.Location = new Point(30, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblSubtitle.Location = new Point(30, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(250, 19);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "View current parking and transaction history";
            //
            // tabControl
            //
            tabControl.Controls.Add(tabCurrent);
            tabControl.Controls.Add(tabHistory);
            tabControl.Font = new Font("Segoe UI", 9.5F);
            tabControl.Location = new Point(30, 75);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(750, 380);
            tabControl.TabIndex = 1;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            //
            // tabCurrent
            //
            tabCurrent.Controls.Add(lblCurrentCount);
            tabCurrent.Controls.Add(dgvCurrent);
            tabCurrent.Location = new Point(4, 24);
            tabCurrent.Name = "tabCurrent";
            tabCurrent.Padding = new Padding(3);
            tabCurrent.Size = new Size(742, 352);
            tabCurrent.TabIndex = 0;
            tabCurrent.Text = "Currently Parked";
            tabCurrent.UseVisualStyleBackColor = true;
            //
            // dgvCurrent
            //
            dgvCurrent.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(245, 247, 250) };
            dgvCurrent.AllowUserToAddRows = false;
            dgvCurrent.AllowUserToDeleteRows = false;
            dgvCurrent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrent.BackgroundColor = Color.White;
            dgvCurrent.BorderStyle = BorderStyle.None;
            dgvCurrent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCurrent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrent.Columns.AddRange(new DataGridViewColumn[] { colCurrentPlate, colCurrentOwner, colCurrentSlot, colCurrentTimeIn, colCurrentFee });
            dgvCurrent.Location = new Point(10, 10);
            dgvCurrent.Name = "dgvCurrent";
            dgvCurrent.ReadOnly = true;
            dgvCurrent.RowHeadersVisible = false;
            dgvCurrent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurrent.Size = new Size(720, 300);
            dgvCurrent.TabIndex = 0;
            //
            // colCurrentPlate
            //
            colCurrentPlate.HeaderText = "Plate Number";
            colCurrentPlate.Name = "colCurrentPlate";
            //
            // colCurrentOwner
            //
            colCurrentOwner.HeaderText = "Owner";
            colCurrentOwner.Name = "colCurrentOwner";
            //
            // colCurrentSlot
            //
            colCurrentSlot.HeaderText = "Slot";
            colCurrentSlot.Name = "colCurrentSlot";
            colCurrentSlot.Width = 60;
            //
            // colCurrentTimeIn
            //
            colCurrentTimeIn.HeaderText = "Time In";
            colCurrentTimeIn.Name = "colCurrentTimeIn";
            //
            // colCurrentFee
            //
            colCurrentFee.HeaderText = "Est. Fee";
            colCurrentFee.Name = "colCurrentFee";
            //
            // lblCurrentCount
            //
            lblCurrentCount.AutoSize = true;
            lblCurrentCount.Font = new Font("Segoe UI", 9F);
            lblCurrentCount.ForeColor = Color.FromArgb(108, 117, 125);
            lblCurrentCount.Location = new Point(10, 320);
            lblCurrentCount.Name = "lblCurrentCount";
            lblCurrentCount.Size = new Size(120, 15);
            lblCurrentCount.TabIndex = 1;
            lblCurrentCount.Text = "Currently Parked: 0";
            //
            // tabHistory
            //
            tabHistory.Controls.Add(lblHistoryCount);
            tabHistory.Controls.Add(dgvHistory);
            tabHistory.Location = new Point(4, 24);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3);
            tabHistory.Size = new Size(742, 352);
            tabHistory.TabIndex = 1;
            tabHistory.Text = "Transaction History";
            tabHistory.UseVisualStyleBackColor = true;
            //
            // dgvHistory
            //
            dgvHistory.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(245, 247, 250) };
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { colHistoryPlate, colHistoryOwner, colHistorySlot, colHistoryTimeIn, colHistoryTimeOut, colHistoryFee });
            dgvHistory.Location = new Point(10, 10);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(720, 300);
            dgvHistory.TabIndex = 0;
            //
            // colHistoryPlate
            //
            colHistoryPlate.HeaderText = "Plate Number";
            colHistoryPlate.Name = "colHistoryPlate";
            //
            // colHistoryOwner
            //
            colHistoryOwner.HeaderText = "Owner";
            colHistoryOwner.Name = "colHistoryOwner";
            //
            // colHistorySlot
            //
            colHistorySlot.HeaderText = "Slot";
            colHistorySlot.Name = "colHistorySlot";
            colHistorySlot.Width = 60;
            //
            // colHistoryTimeIn
            //
            colHistoryTimeIn.HeaderText = "Time In";
            colHistoryTimeIn.Name = "colHistoryTimeIn";
            //
            // colHistoryTimeOut
            //
            colHistoryTimeOut.HeaderText = "Time Out";
            colHistoryTimeOut.Name = "colHistoryTimeOut";
            //
            // colHistoryFee
            //
            colHistoryFee.HeaderText = "Fee";
            colHistoryFee.Name = "colHistoryFee";
            colHistoryFee.Width = 80;
            //
            // lblHistoryCount
            //
            lblHistoryCount.AutoSize = true;
            lblHistoryCount.Font = new Font("Segoe UI", 9F);
            lblHistoryCount.ForeColor = Color.FromArgb(108, 117, 125);
            lblHistoryCount.Location = new Point(10, 320);
            lblHistoryCount.Name = "lblHistoryCount";
            lblHistoryCount.Size = new Size(100, 15);
            lblHistoryCount.TabIndex = 1;
            lblHistoryCount.Text = "Total Transactions: 0";
            //
            // btnRefresh
            //
            btnRefresh.BackColor = Color.FromArgb(27, 42, 74);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(30, 470);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 38);
            btnRefresh.TabIndex = 2;
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
            btnClose.Location = new Point(185, 470);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 38);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // ReportsForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(810, 530);
            Controls.Add(lblSubtitle);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(tabControl);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reports";
            tabControl.ResumeLayout(false);
            tabCurrent.ResumeLayout(false);
            tabCurrent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrent).EndInit();
            tabHistory.ResumeLayout(false);
            tabHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private TabControl tabControl;
        private TabPage tabCurrent;
        private DataGridView dgvCurrent;
        private DataGridViewTextBoxColumn colCurrentPlate;
        private DataGridViewTextBoxColumn colCurrentOwner;
        private DataGridViewTextBoxColumn colCurrentSlot;
        private DataGridViewTextBoxColumn colCurrentTimeIn;
        private DataGridViewTextBoxColumn colCurrentFee;
        private Label lblCurrentCount;
        private TabPage tabHistory;
        private DataGridView dgvHistory;
        private DataGridViewTextBoxColumn colHistoryPlate;
        private DataGridViewTextBoxColumn colHistoryOwner;
        private DataGridViewTextBoxColumn colHistorySlot;
        private DataGridViewTextBoxColumn colHistoryTimeIn;
        private DataGridViewTextBoxColumn colHistoryTimeOut;
        private DataGridViewTextBoxColumn colHistoryFee;
        private Label lblHistoryCount;
        private Button btnRefresh;
        private Button btnClose;
    }
}
