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
            
            studants = studants.OrderByDescending(studant => studant.FirstName)
                               .ThenByDescending(studant => studant.LastName)
                               .ToList();

            foreach(Student studant in studants)
            {
                Console.WriteLine("{0} {1}", studant.FirstName, studant.LastName);
            }
        }
    }
}