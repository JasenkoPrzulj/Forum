using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.DataLayer.Models
{
    public class Topic
    {
        public virtual string Content { get; set; }
        public virtual int ForumId { get; set; }
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }

        public virtual Forum1 Forum { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }

    }
}
