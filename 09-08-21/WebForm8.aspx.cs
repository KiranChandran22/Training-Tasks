using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Gold");
            DropDownList1.Items.Add("Silver");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = DropDownList1.SelectedValue.ToString();
            if (str == "Gold")
            {
                HiddenField1.Value = "3000 per gram";
                Literal1.Text = HiddenField1.Value;
            }
            if (str == "Silver")
            {
                HiddenField1.Value = "1500 per gram";
                Literal1.Text = HiddenField1.Value;

            }
            
        }
    }
}