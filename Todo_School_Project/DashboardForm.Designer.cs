namespace Todo_School_Project
{
    partial class DashboardForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            lblCompletedTasks = new Label();
            lblTotalTasks = new Label();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            lblWelcome = new Label();
            label1 = new Label();
            txtTaskInput = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            dgvTasks = new Guna.UI2.WinForms.Guna2DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTask = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnGoToAdminDashboard = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 128, 190);
            panel1.Controls.Add(btnGoToAdminDashboard);
            panel1.Controls.Add(lblCompletedTasks);
            panel1.Controls.Add(lblTotalTasks);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 503);
            panel1.TabIndex = 1;
            // 
            // lblCompletedTasks
            // 
            lblCompletedTasks.AutoSize = true;
            lblCompletedTasks.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCompletedTasks.ForeColor = Color.White;
            lblCompletedTasks.Location = new Point(92, 188);
            lblCompletedTasks.Name = "lblCompletedTasks";
            lblCompletedTasks.Size = new Size(137, 28);
            lblCompletedTasks.TabIndex = 4;
            lblCompletedTasks.Text = "Completed: 0";
            lblCompletedTasks.Click += lblCompletedTasks_Click;
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.AutoSize = true;
            lblTotalTasks.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold);
            lblTotalTasks.ForeColor = Color.White;
            lblTotalTasks.Location = new Point(91, 145);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(142, 30);
            lblTotalTasks.TabIndex = 3;
            lblTotalTasks.Text = "Total Tasks: 0";
            lblTotalTasks.Click += lblTotalTasks_Click;
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
            btnLogout.Location = new Point(45, 435);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogout.Size = new Size(225, 56);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(23, 148);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(218, 25);
            lblWelcome.TabIndex = 1;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 74);
            label1.Name = "label1";
            label1.Size = new Size(133, 37);
            label1.TabIndex = 0;
            label1.Text = "My Tasks";
            // 
            // txtTaskInput
            // 
            txtTaskInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTaskInput.BorderRadius = 10;
            txtTaskInput.CustomizableEdges = customizableEdges5;
            txtTaskInput.DefaultText = "";
            txtTaskInput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTaskInput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTaskInput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTaskInput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTaskInput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTaskInput.Font = new Font("Segoe UI", 9F);
            txtTaskInput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTaskInput.Location = new Point(28, 24);
            txtTaskInput.Margin = new Padding(3, 4, 3, 4);
            txtTaskInput.Name = "txtTaskInput";
            txtTaskInput.PasswordChar = '\0';
            txtTaskInput.PlaceholderText = "Add a new task ...";
            txtTaskInput.SelectedText = "";
            txtTaskInput.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTaskInput.Size = new Size(393, 40);
            txtTaskInput.TabIndex = 0;
            txtTaskInput.TextChanged += txtTaskInput_TextChanged;
            txtTaskInput.KeyDown += txtTaskInput_KeyDown;
            // 
            // btnAddTask
            // 
            btnAddTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTask.BorderRadius = 10;
            btnAddTask.CustomizableEdges = customizableEdges7;
            btnAddTask.DisabledState.BorderColor = Color.DarkGray;
            btnAddTask.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddTask.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddTask.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddTask.FillColor = Color.FromArgb(19, 128, 190);
            btnAddTask.Font = new Font("Segoe UI", 9F);
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(427, 24);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddTask.Size = new Size(150, 40);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "+ Add Task";
            btnAddTask.Click += btnAddTask_Click;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.AllowDrop = true;
            guna2CustomGradientPanel1.BackColor = Color.White;
            guna2CustomGradientPanel1.Controls.Add(guna2Panel1);
            guna2CustomGradientPanel1.Controls.Add(btnAddTask);
            guna2CustomGradientPanel1.Controls.Add(txtTaskInput);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges11;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.Location = new Point(314, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2CustomGradientPanel1.Size = new Size(618, 503);
            guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.BorderColor = Color.FromArgb(19, 128, 190);
            guna2Panel1.BorderRadius = 8;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(dgvTasks);
            guna2Panel1.CustomBorderColor = Color.White;
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Location = new Point(15, 92);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Padding = new Padding(5);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(562, 350);
            guna2Panel1.TabIndex = 3;
            // 
            // dgvTasks
            // 
            dgvTasks.AllowDrop = true;
            dgvTasks.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(19, 128, 190);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTasks.ColumnHeadersHeight = 35;
            dgvTasks.Columns.AddRange(new DataGridViewColumn[] { colId, colTask, colStatus, btnDelete });
            dgvTasks.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTasks.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTasks.GridColor = Color.FromArgb(231, 229, 255);
            dgvTasks.Location = new Point(8, 0);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.ShowEditingIcon = false;
            dgvTasks.Size = new Size(546, 342);
            dgvTasks.TabIndex = 2;
            dgvTasks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTasks.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTasks.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTasks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTasks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTasks.ThemeStyle.BackColor = Color.White;
            dgvTasks.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTasks.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(19, 128, 190);
            dgvTasks.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTasks.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dgvTasks.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTasks.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTasks.ThemeStyle.HeaderStyle.Height = 35;
            dgvTasks.ThemeStyle.ReadOnly = true;
            dgvTasks.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTasks.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTasks.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F);
            dgvTasks.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTasks.ThemeStyle.RowsStyle.Height = 32;
            dgvTasks.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTasks.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            dgvTasks.CellFormatting += dgvTasks_CellFormatting;
            // 
            // colId
            // 
            colId.HeaderText = "No.";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colTask
            // 
            colTask.HeaderText = "Task Name";
            colTask.MinimumWidth = 6;
            colTask.Name = "colTask";
            colTask.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Action";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnGoToAdminDashboard
            // 
            btnGoToAdminDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGoToAdminDashboard.BorderRadius = 10;
            btnGoToAdminDashboard.CustomizableEdges = customizableEdges1;
            btnGoToAdminDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnGoToAdminDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGoToAdminDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGoToAdminDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGoToAdminDashboard.FillColor = Color.FromArgb(18, 23, 120);
            btnGoToAdminDashboard.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnGoToAdminDashboard.ForeColor = Color.White;
            btnGoToAdminDashboard.Location = new Point(45, 364);
            btnGoToAdminDashboard.Name = "btnGoToAdminDashboard";
            btnGoToAdminDashboard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGoToAdminDashboard.Size = new Size(225, 56);
            btnGoToAdminDashboard.TabIndex = 6;
            btnGoToAdminDashboard.Text = "Admin Dashboard";
            btnGoToAdminDashboard.Click += btnGoToAdminDashboard_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 503);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(panel1);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Todo Task Manager";
            Load += DashboardForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTaskInput;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTasks;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblWelcome;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTask;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn btnDelete;
        private Label lblCompletedTasks;
        private Label lblTotalTasks;
        private Guna.UI2.WinForms.Guna2Button btnGoToAdminDashboard;
    }
}