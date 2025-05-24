using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson4_task.Model.Lesson4_task.Database;
using Lesson4_task.Model;
namespace Lesson4_task.Services
{
    public  class CommentService
    {
        public void AddComment(Comment comment)
        {
            DemirtegramDB.Comments.Add(comment);
        }
        public void DeleteComment(Guid id)
        {
            var comment = DemirtegramDB.Comments.FirstOrDefault(c => c.Id == id);
            if (comment != null)
            {
                DemirtegramDB.Comments.Remove(comment);
            }

        }
        public void GetAllComments()
        {
            foreach(var comment in DemirtegramDB.Comments)
            {
                Console.WriteLine(comment);
            }
        }

        public void UpdateComment(Comment NewComment)
        {
            var comment = DemirtegramDB.Comments.FirstOrDefault(c => c.Id == NewComment.Id);
            if (comment != null)
            {
                comment.Text = NewComment.Text;
                comment.LikeCount = NewComment.LikeCount;
            }
            else
            {
                Console.WriteLine("Bele bir comment tapilmadi");
            }
        }

        public Comment GetCommentById(Guid commentId)
        {
            var comment = DemirtegramDB.Comments.FirstOrDefault(c => c.Id == commentId);
            return comment;
        }
    }
}
