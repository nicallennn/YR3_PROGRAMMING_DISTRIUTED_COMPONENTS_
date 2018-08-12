using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopNetworkEditor
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            //call login authentication method, pass username and pw
            bool loginTrue = AuthenticateLogin(username, txtPassword.Text);
            
            //if login failed
            if (!loginTrue)
            {
                //write error message
                lblError.Text = "You have entered incorrect credentials, please try again.";

            }
            else
            {
                //clear any existing error messages
                lblError.Text = "";

                //hide the current form
                this.Hide();

                //create new instance of user interface
                MainForm ui = new MainForm(username);
                
                //show ui
                ui.Show();
                
            }
            


            
        }

        private bool AuthenticateLogin(string username, string password)
        {
            //change this!!!!
            DBClassesDataContext db = new DBClassesDataContext();

            //run query on admin_users entity and return number of matching rows
            var loginQuery =
                (from user in db.admin_users
                where user.username == username && user.password == password
                select user).Count();

            //if no users found, retun false. else return true
            if(loginQuery == 0)
                return false;

            return true;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
