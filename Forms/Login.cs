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
using register.Forms;

namespace register
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"user.txt";
            var lines = File.ReadAllLines(filePath);
            string[] userData = { ""};

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(TB_Login.Text))
                {
                    userData = lines[i].Split(' ');
                }
            }
            
            if(userData[0] == TB_Login.Text && userData[1] == TB_Pass.Text)
            {
                switch(userData[2])
                {
                    case "user":
                        UserForm usrF = new UserForm();
                        usrF.ShowDialog();
                        break;
                    case "admin":
                        AdminForm admForm = new AdminForm();
                        admForm.ShowDialog();
                        break;
                }
            }
            else MessageBox.Show("Неверные данные", "Ошибка");
            //File.clo
        }
    }
}









//         ,--"""",--.__,---[],-------._         
//       ,"   __,'            \         \--""""""==;-
//     ," _,-"  "/---.___     \       ___\   ,-'',"
//    /,-'      / ;. ,.--'-.__\  _,-"" ,| `,'   /
//   /``""""-._/,-|:\       []\,' ```-/:;-. `. /
//             `  ;:::      ||       /:,;  `-.\
//                =.,'__,---||-.____',.=
//                =(:\_     ||__    ):)=
//               ,"::::`----||::`--':::"._
//             ,':::::::::::||::::::::::::'.
//    .__     ;:::.-.:::::__||___:::::.-.:::\     __,
//       """-;:::( O )::::>_|| _<::::( O )::::-"""
//   =======;:::::`-`:::::::||':::::::`-`:::::\=======
//    ,--"";:::_____________||______________::::""----.          , ,
//         ; ::`._(    |    |||     |   )_,'::::\_,,,,,,,,,,____/,'_,
//       ,;    :::`--._|____[]|_____|_.-'::::::::::::::::::::::::);_
//      ;/ /      :::::::::,||,:::::::::::::::::::::::::::::::::::/
//     /; ``''''----------/,'/,__,,,,,____:::::::::::::::::::::,"
//     ;/                :);/|_;| ,--.. . ```-.:::::::::::::_,"
//    /;                :::):__,'//""\\. ,--.. \:::,:::::_,"
//   ;/              :::::/ . . . . . . //""\\. \::":__,"
//   ;/          :::::::,' . . . . . . . . . . .:`::\
//   ';      :::::::__,'. ,--.. . .,--. . . . . .:`::`
//   ';   __,..--'''-. . //""\\. .//""\\ . ,--.. :`:::`
//   ;    /  \\ .//""\\ . . . . . . . . . //""\\. :`::`
//   ;   /       . . . . . . . . . . . . . . . . .:`::`
//   ;   (          . . . . . . . . . . . . . . . ;:::`
//   ,:  ;,            . . . . . . . . . . . . . ;':::`
//   ,:  ;,             . . . . . . . . . . . . .;`:::
//   ,:   ;,             . . . . . . . . . . . . ;`::;`
//    ,:  ;             . . . . . . . . . . . . ;':::;`
//     :   ;             . . . . . . . . . . . ,':::;
//      :   '.          . . . . . . . .. . . .,':::;`
//       :    `.       . . . . . . . . . . . ;::::;`
//        '.    `-.   . . . . . . . . . . ,-'::::;
//          `:_    ``--..___________..--'':::::;'`
//             `._::,.:,.:,:_ctr_:,:,.::,.:_;'`
//________________`"\/"\/\/'""""`\/"\/""\/"____________________________