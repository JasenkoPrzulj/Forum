using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.DataLayer.Data_Access_Layer;
using Forum.DataLayer.Models;
using System.Data.Entity;

namespace Forum.DataLayer.Business_Logic_Layer
{
    static public class CategoryManager
    {
        public static int InsertCategory(string Name)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Category category = new Category();
                category.Name = Name;
                forumContext.Categories.Add(category);
                forumContext.SaveChanges();
                return category.Id;
            }
        }
        public static List<Category> GetCategories()
        {
            List<Category> Categories = new List<Category>();
            using(ForumContext forumContext = new ForumContext())
            {
                Categories = forumContext.Categories.ToList();
            }
            return Categories;
        }
        public static void DeleteCategory(int Id)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Category category = forumContext.Categories.Where(x => x.Id == Id).FirstOrDefault();
                if(category != null)
                {
                    forumContext.Categories.Remove(category);
                    forumContext.SaveChanges();
                }
            }
        }
        public static void UpdateCategory(int Id, string Name)
        {
            using(ForumContext forumContext = new ForumContext())
            {
                Category category = forumContext.Categories.Where(x => x.Id == Id).FirstOrDefault();
                if(category != null)
                {
                    category.Name = Name;
                    forumContext.SaveChanges();
                }
            }
        }
        public static List<Category> GetCategoriesWithFora()
        {
            List<Category> Categories = new List<Category>();

            using (ForumContext forumContext = new ForumContext())
            {
                Categories = forumContext.Categories.Include(x => x.Fora).ToList();
            }
            return Categories;
        }
    }
}
