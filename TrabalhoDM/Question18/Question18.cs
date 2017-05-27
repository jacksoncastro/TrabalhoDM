using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoDM
{
    internal class Question18 : Question
    {
        public void Execute()
        {
            List<Student> studants = new List<Student>() {
                new Student("Jackson", "Castro"),
                new Student("Abrão", "Silva"),
                new Student("Lucas", "Ramos"),
                new Student("Lucas", "Lima")
            };
            
            studants = studants.OrderBy(studant => studant.GetFirstName())
                               .ThenBy(studant => studant.GetLastName())
                               .ToList();

            foreach(Student studant in studants)
            {
                Console.WriteLine("{0} {1}", studant.GetFirstName(), studant.GetLastName());
            }
        }
    }
}