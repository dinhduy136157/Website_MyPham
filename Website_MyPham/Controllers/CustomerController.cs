﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Website_MyPham.Models;

namespace Website_MyPham.Controllers
{
    public class CustomerController
    {
        SqlConnection con;

        public CustomerController()
        {
            string sqlCon = "Data Source=DESKTOP-7BK339H;Initial Catalog=ptud;Integrated Security=True; TrustServerCertificate=True";
            con = new SqlConnection(sqlCon);

        }
        public List<Customer> DsCustomer()
        {
            List<Customer> ds = new List<Customer>();
            string sql = "select * from Customer";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Customer customer = new Customer();
                customer.customer_id = (int)rd["customer_id"];
                customer.first_name = (string)rd["first_name"];
                customer.last_name = (string)rd["last_name"];
                customer.email = (string)rd["email"];
                customer.password = (string)rd["password"];
                customer.address = (string)rd["address"];
                customer.phone_number = (string)rd["phone_number"];
                ds.Add(customer);
            }
            con.Close();
            return ds;
        }
    }
}