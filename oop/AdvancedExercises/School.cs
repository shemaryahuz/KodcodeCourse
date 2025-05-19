using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExercises
{
    internal class School
    {
        public Student[] students = new Student[10];
        private int _Index;
        public void AddStudent(Student student)
        {
            if (this._Index > 9)
            {
                Console.WriteLine("No more place");
                return;
            }
            this.students[this._Index] = student;
            this._Index++;
        }
    }
}
