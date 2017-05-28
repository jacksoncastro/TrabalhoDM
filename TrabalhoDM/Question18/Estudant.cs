namespace TrabalhoDM
{
   public class Student
    {

        public Student(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}