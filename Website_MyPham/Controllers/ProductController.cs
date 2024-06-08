using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Website_MyPham.Models;

namespace Website_MyPham.Controllers
{
    public class ProductController
    {
        SqlConnection con;

        public ProductController()
        {
            string sqlCon = "Data Source=DESKTOP-7BK339H;Initial Catalog=ptud;Integrated Security=True; TrustServerCertificate=True";
            con = new SqlConnection(sqlCon);

        }
        public List<Product> DsProduct()
        {
            List<Product> ds = new List<Product>();
            string sql = "select * from Product";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Product product = new Product();
                product.product_id = (int)rd["product_id"];
                product.SKU = (string)rd["SKU"];
                product.description = (string)rd["description"];
                product.price = (decimal)rd["price"];
                product.stock = (int)rd["stock"];
                product.Category_catego = (int)rd["Category_catego"];
                product.image = (string)rd["image"];
                ds.Add(product);
            }
            con.Close();
            return ds;
        }
    }
}