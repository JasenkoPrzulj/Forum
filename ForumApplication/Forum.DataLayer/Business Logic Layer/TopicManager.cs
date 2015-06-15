using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Forum.DataLayer.Data_Access_Layer;
using Forum.DataLayer.Models;

namespace Forum.DataLayer.Business_Logic_Layer
{
    public static class TopicManager
    {
        public static int InsertTopic(string Title, string Content, int ForumId)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Topic topic = new Topic();
                topic.Title = Title;
                topic.Content = Content;
                topic.ForumId = ForumId;
                forumContext.Topics.Add(topic);
                forumContext.SaveChanges();
                return topic.Id;
            }
        }
        public static List<Topic> GetTopics()
        {
            List<Topic> Topics = new List<Topic>();
            using(ForumContext forumContext = new ForumContext())
            {
                Topics = forumContext.Topics.ToList();
            }
            return Topics;
        }
        public static void DeleteTopic(int Id)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Topic topic = forumContext.Topics.Where(x => x.Id == Id).FirstOrDefault();
                if(topic != null)
                {
                    forumContext.Topics.Remove(topic);
                    forumContext.SaveChanges();
                }
            }
        }
        public static void UpdateTopic(int Id, string Title, string Content)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Topic topic = forumContext.Topics.Where(x => x.Id == Id).FirstOrDefault();
                if(topic != null)
                {
                    topic.Id = Id;
                    topic.Title = Title;
                    topic.Content = Content;
                    forumContext.SaveChanges();
                }
            }
        }
        public static Topic GetTopics(int Id)
        {
            Topic topic;
            using(ForumContext forumContext = new ForumContext())
            {
                topic = forumContext.Topics.Where(x => x.Id == Id).Include(x =>
                    x.Replies).FirstOrDefault();
            }
            return topic;
        }
    }
}
