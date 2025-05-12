// Attack project

string[] weapons = new string[3] { "Rocket", "Drone", "Tank" };
Random random = new Random();
bool[] houses = new bool[random.Next(1, 1000)];
for (int i = 0; i < houses.Length; i++)
{
    houses[i] = true;
}
Console.WriteLine($"Choose how many houses to destroy:(1 - {houses.Length})");
int toDestroy = 0;
bool valid = int.TryParse(Console.ReadLine(), out toDestroy);
while (!valid || toDestroy < 1 || toDestroy > houses.Length)
{
    Console.WriteLine($"Invalid input! Enter number from 1 to {houses.Length}");
    valid = int.TryParse(Console.ReadLine(), out toDestroy);
}
string[] usedWeapons = new string[toDestroy];
int[] destroyed = new int[toDestroy];
int target;

for (int i = 0; i < toDestroy; i++)
{
    string weapon = weapons[random.Next(0, 3)];
    target = random.Next(0, houses.Length);
    if (houses[target])
    {
        houses[target] = false;
    }
    usedWeapons[i] = weapon;
    destroyed[i] = target + 1;
}
for (int i = 0; i < destroyed.Length; i++)
{
    Console.WriteLine($"House number {destroyed[i]} destroyed by {usedWeapons[i]}");
}