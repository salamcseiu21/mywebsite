using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SnNetworkWebSite.BLL;

namespace SnNetworkWebSite.UI
{
    public partial class LogIn1 : System.Web.UI.Page
    {
       UserManager userManager=new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string userName = Login1.UserName;
            string password = Login1.Password;
            bool result = userManager.IsUserNameAndPasswordCorrect(userName, password);
            if (result)
            {
                e.Authenticated = true;
                Session["UserName"] = userName;
            }
            else
            {
                e.Authenticated = false;
            }
        }
    }
}