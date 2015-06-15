using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.DataLayer.Models
{
    public class Category
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual List<Forum1> Fora { 
            get;
            set;
        }
    }
}
