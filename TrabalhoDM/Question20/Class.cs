using System.Collections.Generic;


namespace TrabalhoDM.Question20
{
    public class Class
    {
        public int TextualId { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }

        public Class(int textualId)
        {
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }
    }
}