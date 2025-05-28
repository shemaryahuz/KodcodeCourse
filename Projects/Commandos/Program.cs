


namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnemyFactory.GetInstance().AddEnemy("Ali");
            EnemyFactory.GetInstance().AddEnemy("Achmad");
            EnemyFactory.GetInstance().AddEnemy("Jhon");
            EnemyFactory.GetInstance().AddEnemy("Bob");
            foreach (Enemy enemy in EnemyFactory.GetInstance().Enemies)
            {
                Console.WriteLine(enemy.Name);
            }
        }
    }
}