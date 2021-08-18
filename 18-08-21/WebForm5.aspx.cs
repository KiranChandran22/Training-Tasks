using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mvz1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "circle.png";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "rec.png";
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "Hexagon.png";
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton4.ImageUrl = "";
        }
    }
}