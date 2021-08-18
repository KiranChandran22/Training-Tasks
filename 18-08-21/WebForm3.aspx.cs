using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mvz1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = TextBox1.Text;
            if(RadioButtonList1.SelectedIndex==0)
            {
                Response.Write("Thank You Mr " + str + " for your feedback");
            }
            if(RadioButtonList1.SelectedIndex==1)
            {
                Response.Write("Thank you Miss " + str + " for your feedback");
            }
        }
    }
}