using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Forum.DataLayer.Data_Access_Layer;
using Forum.DataLayer.Models;
using Forum.DataLayer.Business_Logic_Layer;

namespace Forum.Web
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            TextBox textBox = GridView1.FooterRow.FindControl("txbName") as TextBox;

            if(textBox != null)
            {
                ObjectDataSource1.InsertParameters["Name"].DefaultValue = textBox.Text;
                ObjectDataSource1.Insert();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}