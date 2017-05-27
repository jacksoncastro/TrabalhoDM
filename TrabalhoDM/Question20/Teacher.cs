using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM.Question20
{
    public class Teacher : Person
    {
        public string Name { get; set; }

        public List<Discipline> StudentsTaught { get; set; }

        public Teacher()
        {
            this.StudentsTaught = new List<Discipline>();
        }
    }
}