// Escape Game

// Welcome massege
Console.WriteLine("Welcome to the Escape Game!");
Console.WriteLine("Enter the player's data:");

// Get stealth level
Console.WriteLine("sealth level(0 - 100):");
int stealth;
bool valid = int.TryParse(Console.ReadLine(), out stealth);
while (!valid || stealth < 0 || stealth > 100)
{
    Console.WriteLine("Invalid input! please enter number from 0 to 100:");
    valid = int.TryParse(Console.ReadLine(), out stealth);
}
// Get health level
Console.WriteLine("health (0 - 100):");
int health;
valid = int.TryParse(Console.ReadLine(), out health);
while (!valid || health < 0 || health > 100)
{
    Console.WriteLine("Invalid input! please enter number from 0 to 100:");
    valid = int.TryParse(Console.ReadLine(), out health);
}
// Get danger level
Console.WriteLine("danger level (0 - 100):");
int danger;
valid = int.TryParse(Console.ReadLine(), out danger);
while (!valid || danger < 0 || danger > 100)
{
    Console.WriteLine("Invalid input! please enter number from 0 to 100:");
    valid = int.TryParse(Console.ReadLine(), out danger);
}
// Get number of tools
Console.WriteLine("tools (0 - 5):");
int tools;
valid = int.TryParse(Console.ReadLine(), out tools);
while (!valid || tools < 0 || tools > 5)
{
    Console.WriteLine("Invalid input! please enter number from 0 to 5:");
    valid = int.TryParse(Console.ReadLine(), out tools);
}
// Calculate score
double score = stealth + tools * 5 - danger / 2;

// Change score based on data
if (health < 50)
{
    score -= 10;
}
if (health > 90 && danger < 30)
{
    score += 15;
}
if (stealth > 80 && tools > 1)
{
    score += 8;
}
if (danger > 80)
{
    score -= 12;
}
if (tools == 0)
{
    score += 5;
}
if (danger > 70 && stealth > 85)
{
    score += 5;
}

// Add titles based on final score
string title;
if (score > 89)
{
    title = "Perfect";
}
else if (score < 90 && score > 69)
{
    title = "Survived";
}
else if (score < 70 && score > 49)
{
    title = "Injured";
}
else
{
    title = "Caught";
}

// Print final score and title
if (score >= 0 && score < 101)
{
    Console.WriteLine($"Final score: {score}\nYour title: {title}");
}
else
{
    Console.WriteLine("Final score out of range");
}