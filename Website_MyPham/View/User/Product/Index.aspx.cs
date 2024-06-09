using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Website_MyPham.Controllers;
using Website_MyPham.Models;

namespace Website_MyPham.View.User.Product
{
    public partial class Index : System.Web.UI.Page
    {
        ProductController data = new ProductController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Hienthi();
            }
        }
        public void Hienthi()
        {
            //int productID;
            //if (int.TryParse(Request.QueryString["ProductID"], out productID))
            //{
            //    var product = data.ProductDetail(productID);
            //    if (product != null)
            //    {
            //        // Binding data to controls
            //        productName.InnerText = product.SKU;
            //        productPrice.InnerText = product.Price.ToString("N0") + " đ";
            //        productDescription.InnerText = product.Description;
            //        productImage.Style["background-image"] = "url(./assets/img/product/" + product.Image + ")";
            //        // Binding other product details as needed
            //    }
            //}

        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
    }
}