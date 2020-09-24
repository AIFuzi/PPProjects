using System;
using System.Windows.Forms;
using System.IO;

namespace register
{
    public partial class Register : Form
    {
        public int AdminLevel = 0;

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TB_Login.Text != "" && TB_Pass.Text != "" && TB_Pass1.Text != "")
            {
                if (TB_Pass1.Text == TB_Pass.Text)
                {
                    string filePath = @"user.txt";

                    StreamWriter sw = new StreamWriter(filePath);

                    sw.WriteLine(TB_Login.Text + " " + TB_Pass.Text + " " + "user " + AdminLevel);
                    sw.Flush();

                    MessageBox.Show("Уcпешная регистрация", "Успешно");
                    sw.Close();
                    this.Close();
                }
                else MessageBox.Show("Пароли не совпадают", "Ошибка");
            }
            else MessageBox.Show("Поля не заполенены", "Ошибка");
        }
    }
}
