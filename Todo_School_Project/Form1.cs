using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Todo_School_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username နဲ့ Password ကို ပြည့်စုံစွာ ဖြည့်ပေးပါ။", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Debug.WriteLine("[REGISTER FAILED]: Username သို့မဟုတ် Password မဖြည့်ထားပါ။");
                return;
            }

            // 1. UsersList အစား DataStore.Users လို့ ပြင်ထားပါသည်
            bool isExist = DataStore.Users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (isExist)
            {
                MessageBox.Show("ဒီ Username ကို အသုံးပြုထားပြီး ဖြစ်ပါသည်။ အခြား Username ရွေးပါ။", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Debug.WriteLine($"[REGISTER FAILED]: Username '{username}' က ရှိပြီးသား ဖြစ်နေပါသည်။");
                return;
            }

            // 2. NextUserId အစား Auto ID ရှာပေးသည့် Logic လေး ပြောင်းထားပါသည်
            int nextId = DataStore.Users.Any() ? DataStore.Users.Max(u => u.UserId) + 1 : 1;

            User newUser = new User
            {
                UserId = nextId,
                Username = username,
                Password = password,
                Role = "User",
                IsActive = true
            };

            // 3. UsersList အစား DataStore.Users သို့ ထည့်ပေးပါသည်
            DataStore.Users.Add(newUser);

            Debug.WriteLine("============================================");
            Debug.WriteLine($"[REGISTER SUCCESS]: Account New Created!");
            Debug.WriteLine($"ID: {newUser.UserId} | Username: {newUser.Username} | Role: {newUser.Role}");
            Debug.WriteLine($"Total Users in Memory: {DataStore.Users.Count}");
            Debug.WriteLine("============================================");

            MessageBox.Show("Account သစ် အောင်မြင်စွာ ဆောက်ပြီးပါပြီ!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUsername.Clear();
            txtPassword.Clear();

            // Login Form သို့ ပြန်သွားမည်
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}