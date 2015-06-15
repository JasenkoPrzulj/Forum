using Forum.DataLayer.Business_Logic_Layer;
using Forum.DataLayer.Models;
using Forum.DataLayer.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace Forum.Web
{
    public partial class ForumDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPreRender(EventArgs e)
        {
            int? Id = RequestHelper.GetId(Request);
            if(Id.HasValue)
            {
                Forum1 forum = ForumManager.GetForum1(Id.Value);
                lvTopics.DataSource = forum.Topics;
                lvTopics.DataBind();

                litForumTitle.Text = forum.Name;

                lnkAddTopic.NavigateUrl = "~/AddTopic.aspx?Id=" + Id;
                lnkReturn.NavigateUrl = "~/ForumList.aspx";

            }
            base.OnPreRender(e);
        }

        protected void lbtnDeleteTopic_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string string_id = btn.CommandArgument;
            int Id;
            if (!string.IsNullOrEmpty(string_id) && Int32.TryParse(string_id, out Id))
            {
                TopicManager.DeleteTopic(Id);
            }
        }

    }
}