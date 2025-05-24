using System.Collections.Generic;
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
