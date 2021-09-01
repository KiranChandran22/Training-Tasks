using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project_A.Models
{
    public class projector
    {
        SqlConnection con;
        public projector()
        {
            con = new SqlConnection("Data Source=LAPTOP-D9R0PN2M;Database=Project;Integrated Security=True");
        }
        public DataTable GetVegpizza()
        {
            string selqry = "select Pizza_name,Pizza_price from Pizza_info where Pizza_type='Veg' ";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getfullpizza()
        {
            string selqry = "select Pizza_name,Pizza_price from Pizza_info";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetNoNveg()
        {
            string selqry = "select Pizza_name,Pizza_price from Pizza_info where Pizza_type='Non Veg' ";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable PizzabyName(string Pizza_name)
        {
            String byNoQry = "select Pizza_name,Pizza_id,Pizza_price from Pizza_info where Pizza_name='" + Pizza_name+"'";
            SqlDataAdapter da = new SqlDataAdapter(byNoQry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void insert_into_order(string Pizza_name, int Pizza_id, int quantity, string crust, string toppings,string size,int price)
        {
            string insqry = "insert order_info(Pizza_id, Pizza_name, order_topping, order_quantity, order_crust ,order_size, order_price)values(@pid,@pname,@ptop,@pquan,@pcrust,@psize,@prce)";
            SqlCommand cmd = new SqlCommand(insqry, con);
            cmd.Parameters.AddWithValue("@pname", Pizza_name);
            cmd.Parameters.AddWithValue("@pid", Pizza_id);
            cmd.Parameters.AddWithValue("@prce", price);
            cmd.Parameters.AddWithValue("@pquan", quantity);
            cmd.Parameters.AddWithValue("@pcrust", crust);
            cmd.Parameters.AddWithValue("@ptop", toppings);
            cmd.Parameters.AddWithValue("@psize", size);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable Getorder()
        {
            string selqry = "select order_id,Pizza_name,Pizza_id,order_quantity,order_crust,order_size,order_topping,order_price from order_info";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable Getorderwithquanprice()
        {
            string selqry = "select order_id,Pizza_name,Pizza_id,order_quantity,order_crust,order_size,order_topping,(order_price*order_quantity) as price from order_info";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public void delete(int Pizza_id)
        {
            string delquery = "delete from order_info where Pizza_id=" + Pizza_id;
            SqlCommand cmd = new SqlCommand(delquery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(int order_id, string name,string address,string phno)
        {
            string updt = "update order_info set order_address=@ad, name_of_customer=@name,number_of_customer=@phno where order_id=@oid";
            SqlCommand cmd = new SqlCommand(updt, con);
            cmd.Parameters.AddWithValue("@oid", order_id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@ad", address);
            cmd.Parameters.AddWithValue("@phno", phno);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable gettable()
        {
            string selqry = "select * from order_info";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void addtocrate()
        {
            projector pobj = new projector();
            DataTable dt = new DataTable();
            string selqry = "select order_id,Pizza_id,pizza_name,date_of_order,order_address,name_of_customer,number_of_customer from order_info";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            da.Fill(dt);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                string insqry = "insert order_cart(Pizza_id,pizza_name,order_address,name_of_customer,number_of_customer)values(@pid,@pname,@oad,@nameofc,@noofc)";
                SqlCommand cmd = new SqlCommand(insqry, con);
                cmd.Parameters.AddWithValue("@pid", dt.Rows[i]["Pizza_id"]);
                cmd.Parameters.AddWithValue("@pname", dt.Rows[i]["pizza_name"]);
                cmd.Parameters.AddWithValue("@oad", dt.Rows[i]["order_address"]);
                cmd.Parameters.AddWithValue("@nameofc", dt.Rows[i]["name_of_customer"]);
                cmd.Parameters.AddWithValue("@noofc", dt.Rows[i]["number_of_customer"]);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
        public DataTable gettablecrate()
        {
            string selqry = "select Pizza_id,pizza_name,order_address,date_of_order,name_of_customer,number_of_customer from order_info";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);  
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getorderhistory(string name)
        {
            string selqry = "select Pizza_id,pizza_name,date_of_order,name_of_customer,number_of_customer from order_cart where name_of_customer='" + name + "'";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void truncate()
        {
            string trunc = "TRUNCATE TABLE order_info";
            SqlCommand cmd = new SqlCommand(trunc, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
