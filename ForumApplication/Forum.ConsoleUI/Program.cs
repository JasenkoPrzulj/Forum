using Forum.DataLayer.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ForumContext())
            {
                var categories = context.Categories.ToList();
                foreach(var category in categories)
                {
                    PrintCategory(category);
                    foreach(var forum in context.Fora.Where(x => x.CategoryId == category.Id).ToList())
                    {
                        PrintForum(forum);
                    }
                }
            }
        }

        private static void PrintForum(DataLayer.Models.Forum1 forum)
        {
            Console.WriteLine(forum.Name, forum.Topics, forum.CategoryId);
        }

        private static void PrintCategory(DataLayer.Models.Category category)
        {
            Console.WriteLine(category.Id);
        }
    }
}