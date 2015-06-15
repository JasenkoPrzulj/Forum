using Forum.DataLayer.Data_Access_Layer;
using Forum.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Forum.DataLayer.Business_Logic_Layer
{
    public static class ReplyManager
    {
        public static int InsertReply(string Content, int TopicId)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Reply reply = new Reply();
                
                reply.TopicId = TopicId;
                reply.Content = Content;
                forumContext.Replies.Add(reply);
                forumContext.SaveChanges();
                return reply.Id;
            }
        }
        public static List<Reply> GetReplies()
        {
            List<Reply> Replies = new List<Reply>();
            using(ForumContext forumContext = new ForumContext())
            {
                Replies = forumContext.Replies.ToList();
            }
            return Replies;
        }
        public static void DeleteReply(int Id)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Reply reply = forumContext.Replies.Where(x => x.Id == Id).FirstOrDefault();
                if(reply != null)
                {
                    forumContext.Replies.Remove(reply);
                    forumContext.SaveChanges();
                }
            }
        }
        public static void UpdateReplies(int Id, string Content, int TopicId)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Reply reply = forumContext.Replies.Where(x => x.Id == Id).FirstOrDefault();
                if(reply != null)
                {
                    reply.Id = Id;
                    reply.Content = Content;
                    reply.TopicId = TopicId;
                    forumContext.SaveChanges();
                }
            }
        }
        public static List<Reply> GetRepliesWithTopics(int Id)
        {
            List<Reply> Replies = new List<Reply>();

            using(ForumContext forumContext = new ForumContext())
            {
                Replies = forumContext.Replies.Where(x => x.Id == Id).Include(x => x.Content).ToList();
            }
            return Replies;
        }
    }
}
