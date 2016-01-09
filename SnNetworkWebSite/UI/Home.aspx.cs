using System;
namespace SnNetworkWebSite.UI
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"]!=null)
            {
                messageLabel.Text = "Hi! " + Session["UserName"] + " Welcome to our site";  
            }
                
        }

        protected void signOutButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("LogIn.aspx");
            
        }
    }
}