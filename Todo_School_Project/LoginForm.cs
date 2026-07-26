using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_School_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // 1. LOGIN ခလုတ် နှိပ်သည့်အခါ
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username နဲ့ Password ကို ပြည့်စုံစွာ ဖြည့်ပေးပါ။", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var loggedInUser = DataStore.Users.FirstOrDefault(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);

            if (loggedInUser != null)
            {
                if (!loggedInUser.IsActive)
                {
                    MessageBox.Show("သင့် အကောင့်ကို Admin မှ ပိတ်ထားပါသည်။", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                txtLoginUsername.Clear();
                txtLoginPassword.Clear();

                // 1. Admin ဖြစ်ပါက AdminDashboardForm သို့ ပို့မည်
                if (loggedInUser.Role == "Admin")
                {
                    AdminDashboardForm adminDashboard = new AdminDashboardForm(loggedInUser);
                    adminDashboard.Show();
                    this.Hide(); // Login Form ကို ဖျောက်မည်
                }
                else // 2. Normal User ဖြစ်ပါက DashboardForm သို့ ပို့မည်
                {
                    DashboardForm dashboard = new DashboardForm(loggedInUser);
                    dashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username သို့မဟုတ် Password မှားယွင်းနေပါသည်။", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblGoToRegister_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new Form1();
            registerForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}