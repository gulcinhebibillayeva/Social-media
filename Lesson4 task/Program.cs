using System;
using System.Collections.Generic;
using Lesson4_task.Model;
using Lesson4_task.Model.Lesson4_task.Database;
using Lesson4_task.Services;
namespace Lesson4_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemirtegramDB demirtegramDb = new DemirtegramDB(); 

            Comment comment1 = new Comment()
            {
                Id = Guid.NewGuid(),
                Text = "This is text",
                LikeCount = 1
            };
            Comment comment2 = new Comment()
            {
                Id = Guid.NewGuid(),
                Text = "This is text",
                LikeCount = 2
            };
            Post post1 = new Post()
            {
                Id = Guid.NewGuid(),
                Text = "dksdldalad",
                LikeCount = 3,
                Comments = new List<Comment> { comment1, comment2 }
            };
            Post post2 = new Post()
            {
                Id = Guid.NewGuid(),
                Text = "dsdsidosdlsd",
                LikeCount = 4,
                Comments = new List<Comment> { comment1, comment2 }
            };

            User user1 = new User()
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Surname = "Test",
                Posts = new List<Post> { post1, post2 }
            };
            User user2 = new User()
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Surname = "Test",
                Posts = new List<Post> { post1, post2 }
            };

            DemirtegramDB.Users.Add(user1);
            DemirtegramDB.Users.Add(user2);
            DemirtegramDB.Posts.Add(post1);
            DemirtegramDB.Posts.Add(post2);
            DemirtegramDB.Comments.Add(comment1);
            DemirtegramDB.Comments.Add(comment2);

            UserService userService = new UserService();
            userService.GetAllUsers();


           Console.WriteLine( "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            User updateUser = new User()
            {
                Id = user1.Id,
                Name= "YeniTest",
                Surname= " YeniTest",
                Posts = user1.Posts

            };
            userService.UpdateUser(updateUser);
            userService.GetAllUsers();



            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Comment UpdateComment = new Comment()
            {
                Id = comment1.Id,
                Text = "Yeni comment",
                LikeCount = 5
            };
            CommentService commentservice= new CommentService();    
            commentservice.UpdateComment(UpdateComment);
            Console.WriteLine("Yeni comment1");
            Console.WriteLine(commentservice.GetCommentById(comment1.Id));

        }




       
}
}
