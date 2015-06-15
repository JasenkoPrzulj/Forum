using Forum.DataLayer.Data_Access_Layer;
using Forum.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forum.DataLayer.Business_Logic_Layer
{
    static public class ForumManager
    {
        public static int InsertForum(string Name)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Forum1 forum = new Forum1();
                forum.Name = Name;
                forumContext.Fora.Add(forum);
                forumContext.SaveChanges();
                return forum.Id;
            }
        }
        public static List<Forum1> GetForum1()
        {
            List<Forum1> Fora = new List<Forum1>();
            using(ForumContext forumContext = new ForumContext())
            {
                Fora = forumContext.Fora.ToList();
            }
            return Fora;
        }
        public static void DeleteForum1(int Id)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Forum1 forum = forumContext.Fora.Where(x => x.Id == Id).FirstOrDefault();
                if(forum != null)
                {
                    forumContext.Fora.Remove(forum);
                    forumContext.SaveChanges();
                }
            }
        }
        public static void UpdateForum1(int Id, string Name)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Forum1 forum = forumContext.Fora.Where(x => x.Id == Id).FirstOrDefault();
                if(forum != null)
                {
                    forum.Name = Name;
                    forumContext.SaveChanges();
                }
            }
        }
        public static Forum1 GetForum1(int Id)
        {
            Forum1 forum;
            using (ForumContext forumContext = new ForumContext())
            {
                forum = forumContext.Fora.Where(x => x.Id == Id).Include(x =>
                    x.Topics).FirstOrDefault();
            }
            return forum;
        }
    }
}
