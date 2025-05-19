using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerExercises
{
    internal class Movie
    {
        public string Name;
        public bool IsRated;
        public Movie(string name, bool isRated = false)
        {
            this.Name = name;
            this.IsRated = isRated;
        }
        public void Rate()
        {
            this.IsRated = true;
        }
        public void ShowRate()
        {
            Console.WriteLine(this.IsRated ? "PG" : "Not Rated.");
        }
    }
}
