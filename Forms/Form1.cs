using System;
using System.Windows.Forms;
using System.IO;

namespace register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"user.txt";
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                Login loginForm = new Login();
                loginForm.ShowDialog();
            }
            else MessageBox.Show("Пользователь не найден", "Ошибка");
        }
    }
}
