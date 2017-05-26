namespace TrabalhoDM
{
   public class Student
    {

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private string firstName;

        private string lastName;


        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }


        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
    }
}