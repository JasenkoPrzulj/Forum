using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.DataLayer.Models
{
    public class Reply
    {
        public virtual string Content { get; set; }
        public virtual int Id { get; set; }
        public virtual int TopicId { get; set; }
        public virtual Topic Topic { get; set; }

    }
}
