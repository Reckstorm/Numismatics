using Numismatics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numismatics
{
    public partial class LoginForm : Form
    {
        public Context MyContext = new Context();
        public User? CurrentUser;
        public LoginForm()
        {
            InitializeComponent();
            this.Res_lb.Text = string.Empty;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            CurrentUser = MyContext.Users.FirstOrDefault(x => x.Login.Equals(this.Login_tb.Text));
            if (CurrentUser.ID == 0 || !CurrentUser.Password.Equals(this.Password_tb.Text))
            {
                this.Res_lb.ForeColor = Color.Red;
                this.Res_lb.Text = "Error";
            }
            else
            {
                this.Res_lb.Text = string.Empty;
                this.Login_tb.Text = string.Empty;
                this.Password_tb.Text = string.Empty;
                Numismatics window = new Numismatics();
                window.MyContext = MyContext;
                window.SetUserData(CurrentUser);
                window.Show();
                window.RenderCoins();
                window.Owner = this;
                this.Visible = false;
            }
        }
    }
}
