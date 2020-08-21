using Entity;
using Repository;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class LoginForm : Form
    {
        internal LoginRepo lr;
        public LoginForm()
        {
            InitializeComponent();
            lr = new LoginRepo();
        }

        private void textbox1_Click(object sender, EventArgs e)
        {
            UsernameTb.Clear();
            pictureBox2.BackgroundImage = Properties.Resources.user;
            UsernameTb.ForeColor = Color.FromArgb(255, 99, 55);
        }

        private void textbox2_Click(object sender, EventArgs e)
        {
            PasswordTb.Clear();
            pictureBox3.BackgroundImage = Properties.Resources.password;
            PasswordTb.ForeColor = Color.FromArgb(255, 99, 55);
            PasswordTb.MaxLength = 14;
            PasswordTb.PasswordChar = '*';
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTb.Text;
            string password = PasswordTb.Text;
            Login l = lr.GetUser(username, password);

            if (l != null)
            {
                if (l.Role != 3)
                {
                    MainMenuForm1 m1 = new MainMenuForm1(l);
                    m1.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Now Allowed to log in!!");

                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
