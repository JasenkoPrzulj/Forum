using Forum.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.DataLayer.Data_Access_Layer
{
    public class ForumContext : DbContext
    {
        public ForumContext()
            : base("name=ForumContext")
        {
            Database.SetInitializer<ForumContext>(new ForumDatabaseInitializer());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Forum1> Fora { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Reply> Replies { get; set; }
    }
}
