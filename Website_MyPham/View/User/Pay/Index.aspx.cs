using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Website_MyPham.Controllers;

namespace Website_MyPham.View.User.Pay
{
    public partial class Index : System.Web.UI.Page
    {
        CustomerController data = new CustomerController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["customer_id"] == null)
            {
                Response.Redirect("~/View/User/Index.aspx");
            }
            if (!IsPostBack)
            {
                Hienthi();
            }
        }
        public void Hienthi()
        {
            int customerId = (int)HttpContext.Current.Session["customer_id"];
            var customer = data.takeFirstCustomer(customerId);
            var dataCus = customer[0];
            customer_name.Value = dataCus.first_name + " " + dataCus.last_name;
            customer_address.Value = dataCus.address;
            customer_phone.Value = dataCus.phone_number;
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
    }
}