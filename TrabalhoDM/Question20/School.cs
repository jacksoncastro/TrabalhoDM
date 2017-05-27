using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM.Question20
{
    class School
    {
        public List<Class> Classes { get; set; }

        public School()
        {
            this.Classes = new List<Class>();
        }
    }
}
