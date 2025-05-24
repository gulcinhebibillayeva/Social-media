using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_task.Model
{
    public class Post:BaseEntity
    {
        public string  Text { get; set; }
        public int LikeCount { get; set; }
        public List<Comment> Comments { get; set; }


        public override string ToString()
        {
            return $"Id:{Id},Text{Text},Likecount{LikeCount},Commments:{string.Join(" ",Comments)}";
        }
    }
}
