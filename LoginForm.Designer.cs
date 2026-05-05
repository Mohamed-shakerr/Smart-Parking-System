namespace SmartParking
{
    partial class LoginForm
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
            lblAppYear = new Label();
            lblAppSubtitle = new Label();
            lblAppTitle = new Label();
            pnlSidebarBorder = new Panel();
            pnlMain = new Panel();
            pnlLoginForm = new Panel();
            lblPasswordLabel = new Label();
            lblUsernameLabel = new Label();
            lnkForgotPassword = new LinkLabel();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblLoginSubtitle = new Label();
            lblLoginTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(139, 0, 0);
            pnlSidebar.Controls.Add(lblAppYear);
            pnlSidebar.Controls.Add(lblAppSubtitle);
            pnlSidebar.Controls.Add(lblAppTitle);
            pnlSidebar.Controls.Add(pnlSidebarBorder);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(444, 604);
            pnlSidebar.TabIndex = 0;
            // 
            // lblAppYear
            // 
            lblAppYear.AutoSize = true;
            lblAppYear.Font = new Font("Segoe UI", 10F);
            lblAppYear.ForeColor = Color.FromArgb(200, 160, 160);
            lblAppYear.Location = new Point(34, 340);
            lblAppYear.Name = "lblAppYear";
            lblAppYear.Size = new Size(57, 19);
            lblAppYear.TabIndex = 3;
            lblAppYear.Text = "© 2026";
            // 
            // lblAppSubtitle
            // 
            lblAppSubtitle.AutoSize = true;
            lblAppSubtitle.Font = new Font("Segoe UI", 12F);
            lblAppSubtitle.ForeColor = Color.FromArgb(255, 220, 200);
            lblAppSubtitle.Location = new Point(34, 310);
            lblAppSubtitle.Name = "lblAppSubtitle";
            lblAppSubtitle.Size = new Size(251, 21);
            lblAppSubtitle.TabIndex = 1;
            lblAppSubtitle.Text = "New Mansoura University Campus";
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(28, 250);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(378, 51);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "NMU Smart Parking";
            // 
            // pnlSidebarBorder
            // 
            pnlSidebarBorder.BackColor = Color.FromArgb(100, 0, 0);
            pnlSidebarBorder.Dock = DockStyle.Right;
            pnlSidebarBorder.Location = new Point(441, 0);
            pnlSidebarBorder.Name = "pnlSidebarBorder";
            pnlSidebarBorder.Size = new Size(3, 604);
            pnlSidebarBorder.TabIndex = 4;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(pnlLoginForm);
            pnlMain.Controls.Add(lblLoginSubtitle);
            pnlMain.Controls.Add(lblLoginTitle);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(444, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(675, 604);
            pnlMain.TabIndex = 1;
            // 
            // pnlLoginForm
            // 
            pnlLoginForm.BackColor = Color.White;
            pnlLoginForm.Controls.Add(lblPasswordLabel);
            pnlLoginForm.Controls.Add(lblUsernameLabel);
            pnlLoginForm.Controls.Add(lnkForgotPassword);
            pnlLoginForm.Controls.Add(btnLogin);
            pnlLoginForm.Controls.Add(chkShowPassword);
            pnlLoginForm.Controls.Add(txtPassword);
            pnlLoginForm.Controls.Add(txtUsername);
            pnlLoginForm.Location = new Point(103, 240);
            pnlLoginForm.Name = "pnlLoginForm";
            pnlLoginForm.Size = new Size(430, 350);
            pnlLoginForm.TabIndex = 2;
            // 
            // lblPasswordLabel
            // 
            lblPasswordLabel.AutoSize = true;
            lblPasswordLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPasswordLabel.ForeColor = Color.FromArgb(27, 42, 74);
            lblPasswordLabel.Location = new Point(10, 95);
            lblPasswordLabel.Name = "lblPasswordLabel";
            lblPasswordLabel.Size = new Size(76, 20);
            lblPasswordLabel.TabIndex = 9;
            lblPasswordLabel.Text = "Password";
            // 
            // lblUsernameLabel
            // 
            lblUsernameLabel.AutoSize = true;
            lblUsernameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUsernameLabel.ForeColor = Color.FromArgb(27, 42, 74);
            lblUsernameLabel.Location = new Point(10, 10);
            lblUsernameLabel.Name = "lblUsernameLabel";
            lblUsernameLabel.Size = new Size(80, 20);
            lblUsernameLabel.TabIndex = 8;
            lblUsernameLabel.Text = "Username";
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI", 9.5F);
            lnkForgotPassword.LinkColor = Color.FromArgb(139, 0, 0);
            lnkForgotPassword.Location = new Point(145, 275);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(113, 17);
            lnkForgotPassword.TabIndex = 6;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(139, 0, 0);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(14, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(400, 50);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.FromArgb(108, 117, 125);
            chkShowPassword.Location = new Point(14, 165);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(123, 23);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 249, 250);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.ForeColor = Color.FromArgb(150, 150, 150);
            txtPassword.Location = new Point(14, 120);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 31);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.KeyDown += txtPassword_KeyDown;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(248, 249, 250);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 13F);
            txtUsername.ForeColor = Color.FromArgb(150, 150, 150);
            txtUsername.Location = new Point(14, 35);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 31);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Username";
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.KeyDown += txtUsername_KeyDown;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // lblLoginSubtitle
            // 
            lblLoginSubtitle.AutoSize = true;
            lblLoginSubtitle.Font = new Font("Segoe UI", 11F);
            lblLoginSubtitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblLoginSubtitle.Location = new Point(200, 185);
            lblLoginSubtitle.Name = "lblLoginSubtitle";
            lblLoginSubtitle.Size = new Size(231, 20);
            lblLoginSubtitle.TabIndex = 1;
            lblLoginSubtitle.Text = "Sign in to manage the parking lot";
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblLoginTitle.ForeColor = Color.FromArgb(27, 42, 74);
            lblLoginTitle.Location = new Point(247, 120);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(138, 59);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1119, 604);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NMU Smart Parking - Login";
            WindowState = FormWindowState.Maximized;
            FormClosing += LoginForm_FormClosing;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlLoginForm.ResumeLayout(false);
            pnlLoginForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblAppTitle;
        private Label lblAppSubtitle;
        private Label lblAppYear;
        private Panel pnlSidebarBorder;
        private Panel pnlMain;
        private Label lblLoginTitle;
        private Label lblLoginSubtitle;
        private Panel pnlLoginForm;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private LinkLabel lnkForgotPassword;
        private Label lblUsernameLabel;
        private Label lblPasswordLabel;
    }
}
