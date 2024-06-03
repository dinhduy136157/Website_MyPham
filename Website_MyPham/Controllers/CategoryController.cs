using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Website_MyPham.Models;

namespace Website_MyPham.Controllers
{
    public class CategoryController
    {
        SqlConnection con;

        public CategoryController()
        {
            string sqlCon = "Data Source=DESKTOP-7BK339H;Initial Catalog=ptud;Integrated Security=True; TrustServerCertificate=True";
            con = new SqlConnection(sqlCon);

        }
        public List<Category> DsCategory()
        {
            List<Category> ds = new List<Category>();
            string sql = "select * from Category";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Category category = new Category();
                category.category_id = (int)rd["category_id"];
                category.name = (string)rd["name"];
                ds.Add(category);
            }
            con.Close();
            return ds;
        }
    }
}