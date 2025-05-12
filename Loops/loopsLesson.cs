// Loops

// 1. print numbers from 1 to 10

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
}

// 2. sum all the numbers from 1 to 100
int sum = 0;
for (int i = 1; i < 101; i++)
{
    sum += i;
}
Console.WriteLine($"The sum of the numbers from 1 to 100 is: {sum}");

// 3. go to strings array and print names that start with A
string[] names = ["Avi", "David", "Ben", "Abe"];
Console.WriteLine("The names that start with A:");
foreach (string name in names)
{
    if (name.StartsWith("A"))
    {
        Console.WriteLine(name);
    }