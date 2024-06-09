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
        public List<Product> ProductDetail(int product_id)
        {
            List<Product> ds = new List<Product>();
            string sql = "select * from Product WHERE product_id = @product_id ";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@product_id", product_id);
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
        //---------CHỈNH LẠI CODE
        //public void AddEmployee(Employee nv)
        //{
        //    con.Open();
        //    string sql = "insert into Employee values(@fullName,@avatar,@address,@birthDate, @gender, @phone, @email, @password)";
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.Parameters.AddWithValue("fullName", nv.fullName);
        //    cmd.Parameters.AddWithValue("avatar", nv.avatar);
        //    cmd.Parameters.AddWithValue("address", nv.address);
        //    cmd.Parameters.AddWithValue("birthDate", nv.birthDate);
        //    cmd.Parameters.AddWithValue("gender", nv.gender);
        //    cmd.Parameters.AddWithValue("phone", nv.phone);
        //    cmd.Parameters.AddWithValue("email", nv.email);
        //    cmd.Parameters.AddWithValue("password", nv.password);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

    }
}