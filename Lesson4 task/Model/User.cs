using System.Collections.Generic;
namespace Lesson4_task.Model
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Post> Posts { get; set; }



        public override string ToString()
        {
            return $"Id{Id},Name{Name},Surname{Surname},Posts:{string.Join(" ", Posts)}";
        }
    }
}
