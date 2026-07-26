namespace Todo_School_Project
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtLoginUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtLoginPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblGoToRegister = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.BackColor = Color.White;
            txtLoginUsername.BorderRadius = 10;
            txtLoginUsername.CustomizableEdges = customizableEdges1;
            txtLoginUsername.DefaultText = "";
            txtLoginUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLoginUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLoginUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLoginUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLoginUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLoginUsername.Font = new Font("Segoe UI", 10F);
            txtLoginUsername.ForeColor = Color.Black;
            txtLoginUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLoginUsername.Location = new Point(198, 188);
            txtLoginUsername.Margin = new Padding(3, 5, 3, 5);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.PasswordChar = '\0';
            txtLoginUsername.PlaceholderText = "Username...";
            txtLoginUsername.SelectedText = "";
            txtLoginUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtLoginUsername.Size = new Size(280, 40);
            txtLoginUsername.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.BackColor = Color.White;
            txtLoginPassword.BorderRadius = 10;
            txtLoginPassword.CustomizableEdges = customizableEdges3;
            txtLoginPassword.DefaultText = "";
            txtLoginPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLoginPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLoginPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLoginPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLoginPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLoginPassword.Font = new Font("Segoe UI", 9F);
            txtLoginPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLoginPassword.Location = new Point(198, 286);
            txtLoginPassword.Margin = new Padding(3, 4, 3, 4);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '●';
            txtLoginPassword.PlaceholderText = "Password...";
            txtLoginPassword.SelectedText = "";
            txtLoginPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtLoginPassword.Size = new Size(280, 40);
            txtLoginPassword.TabIndex = 1;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 10;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(41, 128, 185);
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(199, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(280, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(19, 128, 190);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 503);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 151);
            label2.Name = "label2";
            label2.Size = new Size(199, 23);
            label2.TabIndex = 1;
            label2.Text = "Manage your tasks easily";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 81);
            label1.Name = "label1";
            label1.Size = new Size(262, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(199, 90);
            label3.Name = "label3";
            label3.Size = new Size(201, 37);
            label3.TabIndex = 4;
            label3.Text = "Login Account";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.ForeColor = Color.DimGray;
            lblUsername.Location = new Point(199, 154);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(199, 254);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // lblGoToRegister
            // 
            lblGoToRegister.AutoSize = true;
            lblGoToRegister.BackColor = Color.White;
            lblGoToRegister.Cursor = Cursors.Hand;
            lblGoToRegister.ForeColor = Color.FromArgb(19, 128, 190);
            lblGoToRegister.Location = new Point(209, 408);
            lblGoToRegister.Name = "lblGoToRegister";
            lblGoToRegister.Size = new Size(257, 23);
            lblGoToRegister.TabIndex = 7;
            lblGoToRegister.Text = "Don't have an account? Register";
            lblGoToRegister.Click += lblGoToRegister_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblGoToRegister);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtLoginPassword);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(txtLoginUsername);
            panel2.Controls.Add(btnLogin);
            panel2.Location = new Point(320, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(611, 507);
            panel2.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 503);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtLoginUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblGoToRegister;
        private Panel panel2;
        private Label label2;
    }
}