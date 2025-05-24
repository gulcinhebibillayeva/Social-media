namespace Lesson4_task.Model
{
    public class Comment:BaseEntity
    {
        public string Text { get; set; }
        public int LikeCount { get; set; }


        public override string ToString()
        {
            return $"Id{Id}\nText{Text}\nLikeCount:{LikeCount}";
        }
    }
}
