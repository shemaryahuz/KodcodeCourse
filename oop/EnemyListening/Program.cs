using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyListening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy sinwar = new Enemy("Sinwar", 1, "Hamas");
            sinwar.Message();
        }
    }
}
