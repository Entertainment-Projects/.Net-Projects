using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services;

namespace MySecondWebsite
{
    /// <summary>
    /// Summary description for WebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebServices : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(EnableSession = true)]
        public string GetNewProducts() {
            DataSet ds = new DataSet();
            
            using (SqlConnection con = new SqlConnection()) {
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnect"].ConnectionString;
                con.Open();
                SqlCommand cmd = new SqlCommand("GetNewProducts",con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return JsonConvert.SerializeObject(ds.Tables[0], Newtonsoft.Json.Formatting.None);
            }
        }
    }
}
