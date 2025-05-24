using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
