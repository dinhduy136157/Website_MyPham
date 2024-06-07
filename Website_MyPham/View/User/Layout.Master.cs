using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_MyPham.View.User
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        protected void btnDangNhap_Click()
        {
            
        }
        protected static string SubmitFormRegister(string first_name, string last_name, string email, string phone_number, string password, string address)
        {
            return $"{first_name}";
        }
    }
}