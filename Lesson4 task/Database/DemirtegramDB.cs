﻿using System.Collections.Generic;
namespace Lesson4_task.Model
{
    namespace Lesson4_task.Database
    {
        public  class DemirtegramDB
        {
            public static List<User> Users { get; set; } = new List<User>();
            public static List<Post> Posts { get; set; } = new List<Post>();
            public static List<Comment> Comments { get; set; } = new List<Comment>();
        }

    }
}