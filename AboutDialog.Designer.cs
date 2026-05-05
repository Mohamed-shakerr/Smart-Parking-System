using System.Drawing;
using System.Windows.Forms;

namespace SmartParking
{
    partial class AboutDialog
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
            pnlHeader = new Panel();
            lblAppName = new Label();
            lblVersion = new Label();
            pnlBody = new Panel();
            lblDescription = new Label();
            lblUniversity = new Label();
            lblFaculty = new Label();
            lblCourse = new Label();
            lblTech = new Label();
            pnlSeparator = new Panel();
            btnOK = new Button();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(27, 42, 74);
            pnlHeader.Controls.Add(lblVersion);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(450, 80);
            pnlHeader.TabIndex = 0;
            //
            // lblAppName
            //
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(20, 15);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(230, 37);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "NMU Smart Parking";
            //
            // lblVersion
            //
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 9F);
            lblVersion.ForeColor = Color.FromArgb(180, 190, 210);
            lblVersion.Location = new Point(20, 55);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(70, 15);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version 1.0.0";
            //
            // pnlBody
            //
            pnlBody.BackColor = Color.White;
            pnlBody.Controls.Add(lblCopyright);
            pnlBody.Controls.Add(lblTech);
            pnlBody.Controls.Add(lblCourse);
            pnlBody.Controls.Add(lblFaculty);
            pnlBody.Controls.Add(lblUniversity);
            pnlBody.Controls.Add(pnlSeparator);
            pnlBody.Controls.Add(lblDescription);
            pnlBody.Location = new Point(0, 80);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(450, 220);
            pnlBody.TabIndex = 1;
            //
            // lblDescription
            //
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(27, 42, 74);
            lblDescription.Location = new Point(20, 15);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(290, 19);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Smart Parking Management Simulation System";
            //
            // pnlSeparator
            //
            pnlSeparator.BackColor = Color.FromArgb(230, 230, 230);
            pnlSeparator.Location = new Point(20, 45);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(410, 1);
            pnlSeparator.TabIndex = 1;
            //
            // lblUniversity
            //
            lblUniversity.AutoSize = true;
            lblUniversity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUniversity.ForeColor = Color.FromArgb(27, 42, 74);
            lblUniversity.Location = new Point(20, 60);
            lblUniversity.Name = "lblUniversity";
            lblUniversity.Size = new Size(191, 19);
            lblUniversity.TabIndex = 2;
            lblUniversity.Text = "New Mansoura University";
            //
            // lblFaculty
            //
            lblFaculty.AutoSize = true;
            lblFaculty.Font = new Font("Segoe UI", 10F);
            lblFaculty.ForeColor = Color.FromArgb(108, 117, 125);
            lblFaculty.Location = new Point(20, 85);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(290, 19);
            lblFaculty.TabIndex = 3;
            lblFaculty.Text = "Faculty of Computer Science and Engineering";
            //
            // lblCourse
            //
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 10F);
            lblCourse.ForeColor = Color.FromArgb(108, 117, 125);
            lblCourse.Location = new Point(20, 110);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(240, 19);
            lblCourse.TabIndex = 4;
            lblCourse.Text = "Mohamed Shaker • Mohamed Fathy • Mariam Mahmoud\n  " +
                "Ithar Mohamed •  Retaj Ehab • Basant Tarek ";
            //
            // lblTech
            //
            lblTech.AutoSize = true;
            lblTech.Font = new Font("Segoe UI", 9F);
            lblTech.ForeColor = Color.FromArgb(150, 150, 150);
            lblTech.Location = new Point(20, 150);
            lblTech.Name = "lblTech";
            lblTech.Size = new Size(220, 15);
            lblTech.TabIndex = 5;
            lblTech.Text = "Built with C# .NET 8 | Windows Forms";
            //
            // lblCopyright
            //
            lblCopyright = new Label();
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 8.5F);
            lblCopyright.ForeColor = Color.FromArgb(150, 150, 150);
            lblCopyright.Location = new Point(20, 175);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(140, 15);
            lblCopyright.TabIndex = 6;
            lblCopyright.Text = "\u00A9 2026 All Rights Reserved";
            //
            // btnOK
            //
            btnOK.BackColor = Color.FromArgb(27, 42, 74);
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(170, 310);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(120, 35);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            //
            // AboutDialog
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 365);
            Controls.Add(btnOK);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About NMU Smart Parking";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAppName;
        private Label lblVersion;
        private Panel pnlBody;
        private Label lblDescription;
        private Label lblUniversity;
        private Label lblFaculty;
        private Label lblCourse;
        private Label lblTech;
        private Label lblCopyright;
        private Panel pnlSeparator;
        private Button btnOK;
    }
}
