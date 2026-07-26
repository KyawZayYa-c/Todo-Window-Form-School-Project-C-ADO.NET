namespace Todo_School_Project
{
    partial class AdminDashboardForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnGoToUserDashboard = new Guna.UI2.WinForms.Guna2Button();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            lblTotalTasks = new Label();
            lblTotalUsers = new Label();
            lblAdminWelcome = new Label();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tabPage1 = new TabPage();
            dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            tabPage2 = new TabPage();
            dgvUserTasks = new Guna.UI2.WinForms.Guna2DataGridView();
            lblSelectedUser = new Label();
            panel1.SuspendLayout();
            guna2TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserTasks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(19, 128, 190);
            panel1.CausesValidation = false;
            panel1.Controls.Add(btnGoToUserDashboard);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblTotalTasks);
            panel1.Controls.Add(lblTotalUsers);
            panel1.Controls.Add(lblAdminWelcome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 503);
            panel1.TabIndex = 0;
            // 
            // btnGoToUserDashboard
            // 
            btnGoToUserDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGoToUserDashboard.BorderRadius = 10;
            btnGoToUserDashboard.CustomizableEdges = customizableEdges1;
            btnGoToUserDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnGoToUserDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGoToUserDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGoToUserDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGoToUserDashboard.FillColor = Color.FromArgb(18, 23, 120);
            btnGoToUserDashboard.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnGoToUserDashboard.ForeColor = Color.White;
            btnGoToUserDashboard.Location = new Point(29, 364);
            btnGoToUserDashboard.Name = "btnGoToUserDashboard";
            btnGoToUserDashboard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGoToUserDashboard.Size = new Size(225, 56);
            btnGoToUserDashboard.TabIndex = 5;
            btnGoToUserDashboard.Text = "Go to My Tasks";
            btnGoToUserDashboard.Click += btnGoToUserDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BorderRadius = 10;
            btnLogout.CustomizableEdges = customizableEdges3;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.Tomato;
            btnLogout.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(29, 435);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogout.Size = new Size(225, 56);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click_1;
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.AutoSize = true;
            lblTotalTasks.Font = new Font("Segoe UI", 12F);
            lblTotalTasks.ForeColor = Color.White;
            lblTotalTasks.Location = new Point(12, 204);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(123, 28);
            lblTotalTasks.TabIndex = 2;
            lblTotalTasks.Text = "Total Tasks: 0";
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Font = new Font("Segoe UI", 12F);
            lblTotalUsers.ForeColor = Color.White;
            lblTotalUsers.Location = new Point(12, 148);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(126, 28);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "Total Users: 0";
            // 
            // lblAdminWelcome
            // 
            lblAdminWelcome.AutoSize = true;
            lblAdminWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAdminWelcome.ForeColor = Color.White;
            lblAdminWelcome.Location = new Point(2, 78);
            lblAdminWelcome.Name = "lblAdminWelcome";
            lblAdminWelcome.Size = new Size(309, 46);
            lblAdminWelcome.TabIndex = 0;
            lblAdminWelcome.Text = "Admin Dashboard";
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Controls.Add(tabPage1);
            guna2TabControl1.Controls.Add(tabPage2);
            guna2TabControl1.Dock = DockStyle.Fill;
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(314, 0);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(618, 503);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 1;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvUsers);
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(610, 455);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(19, 128, 190);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(19, 128, 190);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.GridColor = Color.FromArgb(231, 229, 255);
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(610, 455);
            dgvUsers.TabIndex = 0;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUsers.ThemeStyle.BackColor = Color.White;
            dgvUsers.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvUsers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            dgvUsers.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUsers.ThemeStyle.HeaderStyle.Height = 40;
            dgvUsers.ThemeStyle.ReadOnly = true;
            dgvUsers.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUsers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F);
            dgvUsers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUsers.ThemeStyle.RowsStyle.Height = 32;
            dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvUserTasks);
            tabPage2.Controls.Add(lblSelectedUser);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(610, 455);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "User Tasks";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvUserTasks
            // 
            dgvUserTasks.AllowUserToAddRows = false;
            dgvUserTasks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvUserTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUserTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(19, 128, 190);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(19, 128, 190);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvUserTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvUserTasks.ColumnHeadersHeight = 35;
            dgvUserTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvUserTasks.DefaultCellStyle = dataGridViewCellStyle6;
            dgvUserTasks.GridColor = Color.FromArgb(231, 229, 255);
            dgvUserTasks.Location = new Point(0, 54);
            dgvUserTasks.Name = "dgvUserTasks";
            dgvUserTasks.ReadOnly = true;
            dgvUserTasks.RowHeadersVisible = false;
            dgvUserTasks.RowHeadersWidth = 51;
            dgvUserTasks.Size = new Size(610, 401);
            dgvUserTasks.TabIndex = 1;
            dgvUserTasks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUserTasks.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUserTasks.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUserTasks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUserTasks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUserTasks.ThemeStyle.BackColor = Color.White;
            dgvUserTasks.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvUserTasks.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvUserTasks.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUserTasks.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F);
            dgvUserTasks.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUserTasks.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUserTasks.ThemeStyle.HeaderStyle.Height = 35;
            dgvUserTasks.ThemeStyle.ReadOnly = true;
            dgvUserTasks.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUserTasks.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUserTasks.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F);
            dgvUserTasks.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUserTasks.ThemeStyle.RowsStyle.Height = 32;
            dgvUserTasks.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUserTasks.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvUserTasks.CellContentClick += dgvUserTasks_CellContentClick;
            // 
            // lblSelectedUser
            // 
            lblSelectedUser.AutoSize = true;
            lblSelectedUser.Location = new Point(12, 13);
            lblSelectedUser.Name = "lblSelectedUser";
            lblSelectedUser.Size = new Size(324, 23);
            lblSelectedUser.TabIndex = 0;
            lblSelectedUser.Text = "Select a user from Users tab to view tasks";
            lblSelectedUser.Click += lblSelectedUser_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 503);
            Controls.Add(guna2TabControl1);
            Controls.Add(panel1);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTotalTasks;
        private Label lblTotalUsers;
        private Label lblAdminWelcome;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUserTasks;
        private Label lblSelectedUser;
        private Guna.UI2.WinForms.Guna2Button btnGoToUserDashboard;
    }
}