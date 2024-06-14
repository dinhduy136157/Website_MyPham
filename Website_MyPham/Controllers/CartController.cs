using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Website_MyPham.Models;

namespace Website_MyPham.Controllers
{
    public class CartController
    {
        SqlConnection con;

        public CartController()
        {
            string sqlCon = "Data Source=DESKTOP-7BK339H;Initial Catalog=ptud;Integrated Security=True; TrustServerCertificate=True";
            con = new SqlConnection(sqlCon);

        }
        public List<Cart> DsCart(int customerId)
        {
            List<Cart> ds = new List<Cart>();
            string sql = "SELECT SKU, image, quantity, price from Cart\r\nJOIN Product ON Cart.Product_product_id = Product.product_id\r\nWHERE Customer_customer_id = @customer_id";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("customer_id", customerId);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Cart cart = new Cart();
                cart.Product = new Product()
                {
                    SKU = rd["SKU"].ToString(),
                    image = rd["image"].ToString(),
                    price = (decimal)rd["price"],
                };
                cart.quantity = (int)rd["quantity"];
                cart.totalPrice = cart.Product.price * Convert.ToInt32(rd["quantity"]);
                ds.Add(cart);
            }
            con.Close();
            return ds;
        }
        public void AddCart(int product_id, int customer_id, int quantity)
        {
            con.Open();
            string sql = "insert into Cart values(@quantity,@Customer_customer_id,@Product_product_id)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("quantity", quantity);
            cmd.Parameters.AddWithValue("Customer_customer_id", customer_id);
            cmd.Parameters.AddWithValue("Product_product_id", product_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void AddOrder(Orders ord)
        {
            con.Open();
            string sql = "insert into Orders values(@order_date,@total_price,@Customer_custo,@Payment_payme, @Shipment_shipm)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("order_date", ord.order_date);
            cmd.Parameters.AddWithValue("total_price", ord.total_price);
            cmd.Parameters.AddWithValue("Customer_custo", ord.Customer_custo);
            cmd.Parameters.AddWithValue("Payment_payme", ord.Payment_payme);
            cmd.Parameters.AddWithValue("Shipment_shipm", ord.Shipmen_shipm);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void AddOrderDetail(OrderItem ord)
        {
            con.Open();
            string sql = "insert into Order_Item values(@quantity,@price,@Product_prod,@Order_order_i, @status)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("quantity", ord.quantity);
            cmd.Parameters.AddWithValue("price", ord.price);
            cmd.Parameters.AddWithValue("Product_prod", ord.Product_prod);
            cmd.Parameters.AddWithValue("Order_order_i", ord.Order_order_i);
            cmd.Parameters.AddWithValue("status", "Chờ xác nhận");
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}