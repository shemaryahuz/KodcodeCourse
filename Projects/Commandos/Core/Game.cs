using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal static class Game
    {
        public static void CreateEnemies()
        {
            // Add enemies
            EnemyFactory enemyFactory = EnemyFactory.GetInstance();
            enemyFactory.AddEnemy("Ali");
            enemyFactory.AddEnemy("Achmad");
            enemyFactory.AddEnemy("Jhon");
            enemyFactory.AddEnemy("Bob");
        }
        public static void CreateCommandos()
        {
            // Add commandos
            CommandoFactory commandoFactory = CommandoFactory.GetInstance();
            commandoFactory.AddCommando("Avi", "12");
            commandoFactory.AddCommando("Abe", "34", "Commando");
            commandoFactory.AddCommando("Albert", "56", "AirCommando");
            commandoFactory.AddCommando("David", "78", "SeaCommando");
        }
    }
}
