using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mvz1
{
    public partial class Task6 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

            

            
protected void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == 0)
            {
                Image1.ImageUrl = "Cookie.jfif";
            }
    


            if (ListBox1.SelectedIndex==1)
            {
                Image1.ImageUrl = "Cake.jfif";
            }
            if(ListBox1.SelectedIndex==2)
            {
                Image1.ImageUrl = "milk-bread.jpg";
            }
            if(ListBox1.SelectedIndex==3)
            {
                Image1.ImageUrl = "Bun.jpg";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == 0)
            {
                Literal1.Text = "2Rs for 1";
            }
            if (ListBox1.SelectedIndex == 1)
            {
                Literal1.Text = "300 rs for 1 kg";
            }
            if (ListBox1.SelectedIndex == 2)
            {
                Literal1.Text = "30 rs for 1 kg";
            }
            if (ListBox1.SelectedIndex == 3)
            {
                Literal1.Text = "3 rs each";
                
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            if (ListBox1.SelectedIndex == 0)
            {
                int num = int.Parse(TextBox1.Text);
                int tot = 2 * num;
                Literal2.Text = "The total is " + tot;
            }
            if (ListBox1.SelectedIndex == 1)
            {
                int num = int.Parse(TextBox1.Text);
                int tot = 300 * num;
                Literal2.Text = "The total is " + tot;
            }
            if (ListBox1.SelectedIndex == 2)
            {
                int num = int.Parse(TextBox1.Text);
                int tot = 30 * num;
                Literal2.Text = "The total is " + tot;
            }
            if (ListBox1.SelectedIndex == 3)
            {
                int num = int.Parse(TextBox1.Text);
                int tot = 3 * num;
                Literal2.Text = "The total is " + tot;

            }
        }
    }
}