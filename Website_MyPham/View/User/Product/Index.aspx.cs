using System;
using System.Collections.Generic;
using System.Web.UI;
using Website_MyPham.Controllers;
using Website_MyPham.Models;

namespace Website_MyPham.View.User.Product
{
    public partial class Index : System.Web.UI.Page
    {
        ProductController data = new ProductController();
        CartController dataCart = new CartController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Hienthi();
            }
        }

        public void Hienthi()
        {
            int productID;
            if (int.TryParse(Request.QueryString["ProductID"], out productID))
            {
                var products = data.ProductDetail(productID);
                if (products != null && products.Count > 0)
                {
                    var product = products[0];
                    // Gán dữ liệu vào các control
                    productName.InnerText = product.SKU;
                    productPrice.InnerText = product.price.ToString("N0") + " đ";
                    productDescription.InnerText = product.description;
                    productImage.Style["background-image"] = "url(../assets/img/product/" + product.image + ")";
                }
                else
                {
                    // Xử lý khi không có sản phẩm nào được tìm thấy
                    productName.InnerText = "Sản phẩm không tồn tại";
                    productPrice.InnerText = string.Empty;
                    productDescription.InnerText = string.Empty;
                    productImage.Style["background-image"] = "none";
                }
            }
            else
            {
                // Xử lý khi tham số ProductID không hợp lệ
                productName.InnerText = "ID sản phẩm không hợp lệ";
                productPrice.InnerText = string.Empty;
                productDescription.InnerText = string.Empty;
                productImage.Style["background-image"] = "none";
            }
        }

       
        protected void AddToCart(object sender, EventArgs e)
        {
            int productID;
            if (int.TryParse(Request.QueryString["ProductID"], out productID))
            {
                var products = data.ProductDetail(productID);
                var product = products[0];
                if (Session["customer_id"] != null)
                {
                    int customerId = (int)Session["customer_id"];
                    Website_MyPham.Models.Cart cart = new Website_MyPham.Models.Cart
                    {
                        quantity = 1,
                        Customer_customer_id = customerId, // Hàm tính tổng giá tiền của giỏ hàng
                        Product_product_id = product.product_id,
                    };
                    dataCart.AddCart(cart);
                    ClientScript.RegisterStartupScript(this.GetType(), "addToCartSuccess", "alert('Hàm AddToCart đã được gọi!');", true);
                }

            }
            else
            {
                 //Hiển thị thông báo thất bại sử dụng alert
                ClientScript.RegisterStartupScript(this.GetType(), "addToCartFailure", "alert('Vui lòng đăng nhập để thêm vào giỏ hàng!');", true);
            }

            ClientScript.RegisterStartupScript(this.GetType(), "addToCartFailure", "alert('AAAAAAAAAA!');", true);

        }
        
        public override void VerifyRenderingInServerForm(Control control)
        {
            // Bắt buộc khi sử dụng các control chạy phía server
        }
    }
}
