using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_School_Project
{
    public partial class DashboardForm : Form
    {
        private User _currentUser;
        private int _taskIdCounter = 1; // Task ID ရေတွက်ရန်

        public DashboardForm()
        {
            InitializeComponent();
        }

        public DashboardForm(User user) : this()
        {
            _currentUser = user;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskText = txtTaskInput.Text.Trim();

            if (string.IsNullOrEmpty(taskText))
            {
                MessageBox.Show("ကျေးဇူးပြု၍ Task အမည် ဖြည့်စွက်ပါ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. DataStore ထဲရှိ အကြီးဆုံး Task ID ကို ရှာပြီး ၁ ပေါင်းမည် (ID မထပ်စေရန်)
            int newTaskId = DataStore.Tasks.Any() ? DataStore.Tasks.Max(t => t.Id) + 1 : 1;

            // 2. DataStore.Tasks ထဲသို့ သွားရောက် သိမ်းဆည်းခြင်း (အရေးကြီးဆုံး!)
            DataStore.Tasks.Add(new TaskItem
            {
                Id = newTaskId,
                UserId = _currentUser.UserId,
                TaskName = taskText,
                Status = "Pending"
            });

            // 3. Grid ကို ပြန်လည် Refresh လုပ်ပေးမည်
            LoadUserTasksFromDataStore();

            // Input field ကို ပြန်ရှင်းခြင်း
            txtTaskInput.Clear();
            txtTaskInput.Focus();
            UpdateTaskCounters();
        }

        private void txtTaskInput_TextChanged(object sender, EventArgs e)
        {
            // လောလောဆယ် ဘာမှ ရေးရန်မလိုပါ
        }

        // 2. DataGridView ပေါ်တွင် Click နှိပ်၍ Status ပြောင်းရန် (Pending <-> Completed)
        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Selected Row ရဲ့ Task ID ကို ယူမည် (Column Index 0 မှာ Task ID ရှိသည်)
            int taskId = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells[0].Value);
            var task = DataStore.Tasks.FirstOrDefault(t => t.Id == taskId);

            // 1. Delete Button (btnDelete) ကို နှိပ်မိပါက DataStore ထဲကပါ ဖျက်မည်
            if (dgvTasks.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if (!dgvTasks.Rows[e.RowIndex].IsNewRow)
                {
                    DialogResult dialog = MessageBox.Show("ဒီ Task ကို ဖျက်ရန် သေချာပါသလား?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        if (task != null)
                        {
                            DataStore.Tasks.Remove(task); // DataStore ထဲကပါ ဖျက်လိုက်မည်
                        }
                        LoadUserTasksFromDataStore();
                    }
                }
            }
            // 2. Status Column (Index 2) ကို နှိပ်ပါက Status ပြောင်းမည်
            else if (e.ColumnIndex == 2)
            {
                if (task != null)
                {
                    task.Status = (task.Status == "Pending") ? "Completed" : "Pending"; // DataStore ထဲမှာ ပြောင်းမည်
                }
                LoadUserTasksFromDataStore();
            }
            UpdateTaskCounters();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load_1(object sender, EventArgs e)
        {
            // Login ဝင်လာတဲ့ user ရှိရင် Label မှာ နာမည်သွားပြမည်
            if (_currentUser != null)
            {
                lblWelcome.Text = $"Hello, {_currentUser.Username}!";
                LoadUserTasksFromDataStore();

                if (_currentUser.Role == "Admin")
                {
                    btnGoToAdminDashboard.Visible = true;
                }
                else
                {
                    btnGoToAdminDashboard.Visible = false;
                }
            }
            UpdateTaskCounters();
        }

        private void LoadUserTasksFromDataStore()
        {
            dgvTasks.Rows.Clear();

            if (_currentUser == null) return;

            // မိမိ User ID နဲ့ သက်ဆိုင်သော Task များကို ယူမည်
            var myTasks = DataStore.Tasks.Where(t => t.UserId == _currentUser.UserId).ToList();

            foreach (var task in myTasks)
            {
                // Grid Column အစီအစဉ်အတိုင်း (Task ID, Task Name, Status) ထည့်ပေးပါ
                dgvTasks.Rows.Add(task.Id, task.TaskName, task.Status);
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void dgvTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Completed")
                {
                    e.CellStyle.ForeColor = Color.ForestGreen;
                    e.CellStyle.SelectionForeColor = Color.ForestGreen;
                }
                else if (status == "Pending")
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                    e.CellStyle.SelectionForeColor = Color.DarkOrange;
                }
            }
        }

        private void lblTotalTasks_Click(object sender, EventArgs e)
        {

        }

        private void lblCompletedTasks_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTaskCounters()
        {
            int total = dgvTasks.Rows.Count;
            int completed = 0;

            foreach (DataGridViewRow row in dgvTasks.Rows)
            {
                // Status Column (Index 2) မှာ Completed ဖြစ်နေသလား စစ်သည်
                if (row.Cells[2].Value?.ToString() == "Completed")
                {
                    completed++;
                }
            }

            // Label တွေမှာ ဂဏန်း သွားပြင်ပေးမည်
            lblTotalTasks.Text = $"Total Tasks: {total}";
            lblCompletedTasks.Text = $"Completed: {completed}";
        }

        private void txtTaskInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                // Add Task Button နှိပ်လိုက်သည့် Event ကို တိုက်ရိုက် လှမ်းခေါ်ခြင်း
                btnAddTask_Click(sender, e);
            }
        }

        private void btnGoToAdminDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboard = new AdminDashboardForm(_currentUser);
            adminDashboard.WindowState = this.WindowState;
            adminDashboard.Show();

            // လက်ရှိ User Dashboard ကို ပိတ်လိုက်မည်
            this.Close();
        }
    }
}