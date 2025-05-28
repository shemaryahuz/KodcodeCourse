


namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add enemies
            EnemyFactory enemyFactory = EnemyFactory.GetInstance();
            enemyFactory.AddEnemy("Ali");
            enemyFactory.AddEnemy("Achmad");
            enemyFactory.AddEnemy("Jhon");
            enemyFactory.AddEnemy("Bob");
            foreach (Enemy enemy in enemyFactory.Enemies)
            {
                Console.WriteLine(enemy.Name);
            }

            // Add commandos
            CommandoFactory commandoFactory = CommandoFactory.GetInstance();
            commandoFactory.AddCommando("Avi", "12");
            commandoFactory.AddCommando("Abe", "34", "Commando");
            commandoFactory.AddCommando("Albert", "56", "AirCommando");
            commandoFactory.AddCommando("David", "78", "SeaCommando");
            foreach (Commando commando in commandoFactory.Commandos)
            {
                Console.WriteLine(commando.SayName("General"));
                Console.WriteLine(commando.SayName("Colonel"));
                Console.WriteLine(commando.SayName("Turay"));
                commando.Attack();
            }
        }
    }
}