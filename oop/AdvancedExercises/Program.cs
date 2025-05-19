using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example for Exercise 20:
            School school = new School();
            Student student1 = new Student("Noa");
            school.AddStudent(student1);
            Student student2 = new Student("Lior");
            school.AddStudent(student2);
            Student student3 = new Student("Eitan");
            school.AddStudent(student3);
            Console.WriteLine("Students:");
            foreach (Student student in school.students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
