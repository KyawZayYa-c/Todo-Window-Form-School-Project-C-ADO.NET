using System;
using System.Data;
using System.Diagnostics; // 👇 Console/Output window ထဲ စာထုတ်ရန် လိုအပ်သည်
using System.Linq;
using System.Windows.Forms;

namespace Todo_School_Project
{
    public partial class AdminDashboardForm : Form
    {
        private User _adminUser;

        public AdminDashboardForm(User admin)
        {
            InitializeComponent();
            _adminUser = admin;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ReadOnly = true;

            if (dgvUserTasks != null)
            {
                dgvUserTasks.AllowUserToAddRows = false;
                dgvUserTasks.AllowUserToDeleteRows = false;
                dgvUserTasks.ReadOnly = true;
            }

            SetupUserGrid();
            SetupTaskGrid();
            LoadSummaryCounters();
            LoadUserList();
            LoadAllUserTasks();

            // 🔍 DEBUG: DataStore ထဲရှိ Tasks အားလုံးကို Output Window တွင် ထုတ်ပြမည်
            Debug.WriteLine("===== [DataStore Tasks List] =====");
            foreach (var t in DataStore.Tasks)
            {
                Debug.WriteLine($"Task ID: {t.Id} | Task Name: {t.TaskName} | User ID: {t.UserId} | Status: {t.Status}");
            }
            Debug.WriteLine("==================================");
        }

        private void LoadSummaryCounters()
        {
            int totalUsers = DataStore.Users.Count(u => u.Role == "User");
            int totalTasks = DataStore.Tasks.Count;

            lblTotalUsers.Text = $"Total Users: {totalUsers}";
            lblTotalTasks.Text = $"Total Tasks: {totalTasks}";
        }

        private void SetupUserGrid()
        {
            dgvUsers.Columns.Clear();
            dgvUsers.Columns.Add("colUserId", "User ID");
            dgvUsers.Columns.Add("colUsername", "Username");
            dgvUsers.Columns.Add("colStatus", "Account Status");

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn
            {
                Name = "btnToggleStatus",
                HeaderText = "Action",
                UseColumnTextForButtonValue = false
            };
            dgvUsers.Columns.Add(btnCol);
        }

        private void SetupTaskGrid()
        {
            if (dgvUserTasks == null) return;

            dgvUserTasks.Columns.Clear();
            dgvUserTasks.Columns.Add("colTaskId", "Task ID");
            dgvUserTasks.Columns.Add("colUsername", "User Name");
            dgvUserTasks.Columns.Add("colTaskName", "Task Name");
            dgvUserTasks.Columns.Add("colTaskStatus", "Status");
        }

        private void LoadUserList()
        {
            dgvUsers.Rows.Clear();

            foreach (var u in DataStore.Users.Where(user => user.Role == "User"))
            {
                string statusText = u.IsActive ? "Active" : "Inactive";
                string btnText = u.IsActive ? "Disable" : "Enable";

                dgvUsers.Rows.Add(u.UserId, u.Username, statusText, btnText);
            }
        }

        // User Grid ကို Click နှိပ်လိုက်ပါက အလုပ်လုပ်မည့်နေရာ
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int selectedUserId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
            var selectedUser = DataStore.Users.FirstOrDefault(u => u.UserId == selectedUserId);

            if (selectedUser == null) return;

            // 🔍 DEBUG: Click နှိပ်လိုက်သော User ID ကို ထုတ်ပြမည်
            Debug.WriteLine($"\n>>> Selected User ID: {selectedUserId} ({selectedUser.Username})");

            if (dgvUsers.Columns[e.ColumnIndex].Name == "btnToggleStatus")
            {
                selectedUser.IsActive = !selectedUser.IsActive;
                string msg = selectedUser.IsActive ? "ဖွင့်ပေးလိုက်ပါပြီ။" : "ပိတ်လိုက်ပါပြီ။";
                LoadUserList();
            }
            else
            {
                lblSelectedUser.Text = $"{selectedUser.Username}'s Todo Tasks List";
                LoadUserTasks(selectedUser.UserId);
            }
        }

        private void LoadUserTasks(int userId)
        {
            if (dgvUserTasks == null) return;

            dgvUserTasks.Rows.Clear();

            var userTasks = DataStore.Tasks.Where(t => t.UserId == userId).ToList();

            // 🔍 DEBUG: ထို User ID အတွက် Task မည်မျှတွေ့သနည်း
            Debug.WriteLine($">>> Found {userTasks.Count} tasks for User ID: {userId}");

            foreach (var t in userTasks)
            {
                dgvUserTasks.Rows.Add(t.Id, t.TaskName, t.Status);
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // DataStore ထဲရှိ Tasks အားလုံးနှင့် Owner User Name ကို ဆွဲထုတ်ပြမည့် Method
        private void LoadAllUserTasks()
        {
            if (dgvUserTasks == null) return;

            dgvUserTasks.Rows.Clear();

            foreach (var task in DataStore.Tasks)
            {
                // Task ၏ UserId နဲ့ ကိုက်ညီသော User ကို DataStore ထဲမှ ရှာမည်
                var owner = DataStore.Users.FirstOrDefault(u => u.UserId == task.UserId);

                // User တွေ့ရင် Username ယူမည်၊ မတွေ့ရင် Unknown ဟု ပြမည်
                string username = (owner != null) ? owner.Username : "Unknown";

                // Grid ထဲသို့ (Task ID, User Name, Task Name, Status) ထည့်မည်
                dgvUserTasks.Rows.Add(task.Id, username, task.TaskName, task.Status);
            }
        }

        private void lblSelectedUser_Click(object sender, EventArgs e) { }
        private void dgvUserTasks_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnGoToUserDashboard_Click(object sender, EventArgs e)
        {

            DashboardForm userDashboard = new DashboardForm(_adminUser);
            userDashboard.WindowState = this.WindowState;
            userDashboard.Show();

            // Admin Dashboard ကို ပိတ်ချင်ရင် this.Close(); သို့မဟုတ် ကွယ်ထားချင်ရင် this.Hide(); သုံးနိုင်ပါသည်
            this.Hide();
        }
    }
}