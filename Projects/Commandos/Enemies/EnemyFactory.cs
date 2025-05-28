using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class EnemyFactory
    {
        private static EnemyFactory _Instance;
        private EnemyFactory() { }
        public static EnemyFactory GetInstance()
        {
            if (_Instance is null)
            {
                _Instance = new EnemyFactory();
            }
            return _Instance;
        }
        public List<Enemy> Enemies { get; set; } = new List<Enemy>();
        public void AddEnemy(string name)
        {
            Enemies.Add(new Enemy(name));
        }
    }
}