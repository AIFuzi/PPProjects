using System;
using System.Windows.Forms;
using System.IO;

namespace register.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm(int AdminLevel)
        {
            InitializeComponent();

            string filePath = @"user.txt";
            StreamReader sr = new StreamReader(filePath);

            var lines = File.ReadAllLines(filePath);
            string[] userData = { ""};

            for(int i = 0; i < lines.Length; i++)
            {
                userData = lines[i].Split(' ');
                DG_AdminView.Rows.Add(userData);
            }

            switch(AdminLevel)
            {
                case 1:
                    //1 уровень может просматривать логины всех 
                    B_SaveData.Enabled = false;
                    DG_AdminView.Columns[1].Visible = false;
                    DG_AdminView.Columns[3].ReadOnly = true;
                    DG_AdminView.Columns[2].Visible = false;
                    break;
                case 2:
                    //2 уровень может изменять данные только пользователям
                    DG_AdminView.Columns[3].Visible = false;
                    for (int i = 0; i < DG_AdminView.RowCount; i++)
                    {
                        if(DG_AdminView[2, i].Value != null)
                        {
                            if (DG_AdminView[2, i].Value.ToString() == "admin")
                            {
                                DG_AdminView.Rows[i].ReadOnly = true;
                            }
                        }
                    }
                    break;
                case 3:
                    //3 Уровень может изменять всё
                    break;
            }

            label1.Text = "Admin level: " + AdminLevel.ToString();
        }

        private void B_SaveData_Click(object sender, EventArgs e)
        {
            string filePath = @"user.txt";
            StreamWriter sw = new StreamWriter(filePath);

            int CurrenRow = 0;
            for(int j = 0; j < DG_AdminView.RowCount; j++)
            {
                for (int i = 0; i < DG_AdminView.ColumnCount; i++)
                {
                    sw.Write(DG_AdminView[i, CurrenRow].Value + " ");
                    sw.Flush();
                }
                CurrenRow++;
                sw.Write("\n");
            }
            sw.Close();
        }
    }
}
