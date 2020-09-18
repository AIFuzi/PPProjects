using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace register
{
    public partial class Register : Form
    {
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

                    StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default);

                    sw.WriteLine(TB_Login.Text + " " + TB_Pass.Text + " " + "user ");
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
