using Forum.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.DataLayer.Data_Access_Layer
{
    public class ForumDatabaseInitializer : DropCreateDatabaseIfModelChanges<ForumContext>
    {
        protected override void Seed(ForumContext context)
        {
            var categories = new List<Category>
            {
                new Category {Id = 1, Name = "Development"},
                new Category {Id = 2, Name = "Administration"}
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();

            var fora = new List<Forum1>
            {
                new Forum1 {Id = 1, Name = "SharePoint", CategoryId = categories.Single(x => x.Id == 1).Id},
                new Forum1 {Id = 2, Name = "Web", CategoryId = categories.Single(x => x.Id == 1).Id},
                new Forum1 {Id = 3, Name = "SQL Server", CategoryId = categories.Single(x => x.Id == 2).Id}
            };
            context.Fora.AddRange(fora);
            context.SaveChanges();

        }
    }
}
