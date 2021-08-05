using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Task : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                if (DropDownList1.SelectedValue == "Tamil Nadu")
                {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Chennai");
                    ListBox1.Items.Add("Coimbatore");
                    ListBox1.Items.Add("Madurai");
                    ListBox1.Items.Add("Trichy");
                }
               else if (DropDownList1.SelectedValue == "Karnataka")
                {
                ListBox1.Items.Clear();
                    ListBox1.Items.Add("Bangalore");
                    ListBox1.Items.Add("Hubuli");
                    ListBox1.Items.Add("Mangalore");
                    ListBox1.Items.Add("Mysore");
                }
                else if (DropDownList1.SelectedValue == "Andra Pradash")
                {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Vishakaptinam");
                    ListBox1.Items.Add("Secondrabad");
                    ListBox1.Items.Add("Nellore");
                    ListBox1.Items.Add("Thirupathi");
                }
                else if (DropDownList1.SelectedValue == "Kerala")
                {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Ernakulam");
                    ListBox1.Items.Add("Angamaly");
                    ListBox1.Items.Add("Kotayyam");
                    ListBox1.Items.Add("Thirussur");
                }
                else if (DropDownList1.SelectedValue == "Madhya Pradash")
                {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Mumbai");
                    ListBox1.Items.Add("Pune");
                }
            
        }
    }
}