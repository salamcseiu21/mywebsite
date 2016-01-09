using System;
using SnNetworkWebSite.BLL;
using SnNetworkWebSite.Models;

namespace SnNetworkWebSite.UI
{
    public partial class LogIn : System.Web.UI.Page
    {
        UserManager userManager=new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void resetButton_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        private void ClearAllTextBox()
        {
            userNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            confirmPasswordTextBox.Text = string.Empty;
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            string userId = Guid.NewGuid().ToString().Replace("-","").ToUpper();
            string userName = userNameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            User anUser=new User(userId,userName,email,password);
            string messsage = userManager.Save(anUser);
            messageLabel.Text = messsage;
            ClearAllTextBox();
            //Response.Redirect("LogIn.aspx");
        }
    }
}