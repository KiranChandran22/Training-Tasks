using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = Request.QueryString[0].ToString();
            if (str == "Breakfast")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Idli");
                ListBox1.Items.Add("Dosa");
                ListBox1.Items.Add("Chapathi");
            }
            if (str == "Lunch")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Idli");
                ListBox1.Items.Add("Dosa");
                ListBox1.Items.Add("Chapathi");
            }
            if (str == "Snacks")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Idli");
                ListBox1.Items.Add("Dosa");
                ListBox1.Items.Add("Chapathi");

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}