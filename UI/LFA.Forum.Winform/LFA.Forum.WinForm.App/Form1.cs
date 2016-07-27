using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LFA.Forum.BLL;
using LFA.Forum.BLL.Model;
namespace LFA.Forum.WinForm.App
{
    public partial class Form1 : Form
    {
        string UserSession = "None";
        public Form1()
        {
            InitializeComponent();
            
        }

      
        private void btn_Submit_Click(object sender, EventArgs e)
        {
          var _userName= txt_Username.Text;
          var _password = txt_Password.Text;
          UsersBLL _userBll = new UsersBLL();
         var user= _userBll.GetAllUsersDetail().Where(x => x.UserName == _userName && x.HashPassword == _password).FirstOrDefault();
            if(user==null)
            {
                MessageBox.Show("UserName or Password is incorrect.If you don't have Signup then Please SignUp from another tab.", "Failed to Signin", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                UserSession = _userName;
                MessageBox.Show("Login Sucessfull", "Login Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            UsersBLL userBll=new UsersBLL();
            user.UserName= txt_UserNameS.Text;
            user.FirstName = txt_FirstNameS.Text;
            user.LastName = txt_LastNameS.Text;
            user.Email = txt_EmailS.Text;
            user.Created = 0;
            user.LastActivity = DateTime.Now;
            user.UserStatus = 1;

            if(txt_pswdS.Text==txt_RePswdS.Text)
            {
              user.HashPassword=txt_pswdS.Text;
             var checkstatus= userBll.AddUser(user);
                if(checkstatus)
                {
                    MessageBox.Show("Signup Sucessfull", "Sign Up Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Password doesnot match.Please retype.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
