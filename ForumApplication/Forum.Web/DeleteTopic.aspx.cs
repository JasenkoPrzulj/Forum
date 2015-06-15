using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forum.Web
{
    public partial class DeleteTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnDelete_Click(object sender, EventArgs e)
        //{
        //    string string_id = Request.QueryString["Id"];
        //    int ForumId;
        //    if(!string.IsNullOrEmpty(string_id) && Int32.TryParse(string_id, out ForumId))
        //    {
        //        ddlTitle.Items.Remove(ddlTitle);
        //    }
        //}

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            string string_id = Request.QueryString["Id"];
            int ForumId;
            if(!string.IsNullOrEmpty(string_id) && Int32.TryParse(string_id, out ForumId))
            {
                Response.Redirect("~/ForumDetails.aspx?Id=" + ForumId);
            }
        }
    }
}