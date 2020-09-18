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

namespace register.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            string filePath = @"user.txt";
            StreamReader sr = new StreamReader(filePath);

            string line;
            while ((line = sr.ReadLine()) != null) LB_Users.Items.Add(line);
        }
    }
}
