using Forum.DataLayer.Business_Logic_Layer;
using Forum.DataLayer.Data_Access_Layer;
using Forum.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forum.Web
{
    public partial class ForumList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lvCategories.DataSource = CategoryManager.GetCategoriesWithFora();
            lvCategories.DataBind();
        }

        protected void lvCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}