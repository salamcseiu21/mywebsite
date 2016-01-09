using System.Data.SqlClient;
using System.Web.Configuration;

namespace SnNetworkWebSite.DAL
{
    public class DBGateway
    {
        private SqlConnection connectionObj;

        public SqlConnection ConnectionObj
        {
            get { return connectionObj; }
        }

        public SqlCommand CommandObj
        {
            get
            {
                commandObj.Connection = connectionObj;
                return commandObj;
            }
        }

        private SqlCommand commandObj;

        public DBGateway()
        {
            connectionObj = new SqlConnection(WebConfigurationManager.ConnectionStrings["snNetworkDbConnectionString"].ConnectionString);
            commandObj=new SqlCommand();
        }
    }
}