using Forum.DataLayer.Business_Logic_Layer;
using Forum.DataLayer.Data_Access_Layer;
using Forum.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forum.Web
{
    public partial class AddTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnSave_Click(object sender, EventArgs e)
        {
            string string_id = Request.QueryString["Id"];
            int ForumId;
            if (!string.IsNullOrEmpty(string_id) && Int32.TryParse(string_id, out ForumId))
            {
                string Title = tbTitle.Text;
                string Content = tbContent.Text;

                TopicManager.InsertTopic(Title, Content, ForumId);

                Response.Redirect("~/ForumDetails.aspx?Id=" + ForumId);
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            string string_id = Request.QueryString["Id"];
            int ForumId;
            if (!string.IsNullOrEmpty(string_id) && Int32.TryParse(string_id, out ForumId))
            {
                Response.Redirect("~/ForumDetails.aspx?Id=" + ForumId);
            }
        }
    }
}