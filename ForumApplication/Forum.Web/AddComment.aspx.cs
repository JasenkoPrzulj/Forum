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
    public partial class AddComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string string_id = Request.QueryString["Id"];
            int Id;
            if (!string.IsNullOrEmpty(string_id) && Int32.TryParse(string_id, out Id))
            {

            }
        }
        protected override void OnPreRender(EventArgs e)
        {
            int? Id = RequestHelper.GetId(Request);
            if (Id.HasValue)
            {
                Topic topic = TopicManager.GetTopics(Id.Value);
                lvReplies.DataSource = topic.Replies;
                lvReplies.DataBind();

                litTopicTitle.Text = topic.Title;
                litTopicTitleInside.Text = topic.Title;
                litTopicContent.Text = topic.Content;

                lnkAddComment.NavigateUrl = "~/AddComment.aspx?Id=" + Id;
                lnkReturn.NavigateUrl = "~/ForumDetails.aspx?Id=" + topic.ForumId;
                lnkReturnToForum.NavigateUrl = "~/ForumList.aspx";
            }
            base.OnPreRender(e);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string string_id = Request.QueryString["Id"];
            int TopicId;
            if (!string.IsNullOrEmpty(string_id) && Int32.TryParse(string_id, out TopicId))
            {
                string Content = tbContent.Text;
                
                ReplyManager.InsertReply(Content, TopicId);

                Response.Redirect("~/TopicDetails.aspx?Id=" + TopicId);
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            string string_id = Request.QueryString["Id"];
            int TopicId;
            if(!string.IsNullOrEmpty(string_id) && Int32.TryParse(string_id, out TopicId))
            {
                Response.Redirect("~/TopicDetails.aspx?Id=" + TopicId);
            }
        }
    }
}