// Exercise 1: Build a Name list for a Report

List<string> names = new List<string>{ "Avi", "David", "Ben", "Mike", "Israel" };
names.Add("Abe");
names.Add("Jhon");
names.Remove("Ben");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{i}. {names[i]}");
}

// Exercise 2: Track item quantities

Dictionary<string, int> items = new Dictionary<string, int>();
items["Computers"] = 4;
items["Keyboards"] = 7;
items["Phones"] = 10;
items["Phones"] -= 3;
foreach (string item in items.Keys)
{
    Console.WriteLine($"{item}: {items[item]}");
}

// Exercise 3: Store Users Data

Dictionary<string, string>[] users = new Dictionary<string, string>[2];
for (int  i = 0; i < users.Length; i++)
{
    users[i] = new Dictionary<string, string>();
    Console.WriteLine($"User {i + 1} enter your Name:");
    users[i]["Name"] = Console.ReadLine();
    Console.WriteLine($"User {i + 1} enter your Email:");
    users[i]["Email"] = Console.ReadLine();
    Console.WriteLine($"User {i + 1} enter your Phone number:");
    users[i]["Phone"] = Console.ReadLine();
}
int counter = 1;
foreach (Dictionary<string, string> user in users)
{
    Console.WriteLine($"User {counter}:\nName: {user["Name"]}\nEmail: {user["Email"]}\nPhone number: {user["Phone"]}");
    counter++;
}

// Exercise 4: Check for registered user

List<string> users = new List<string> {"Israel", "David", "Avi"};
Console.WriteLine("Enter Username:");
string input = Console.ReadLine();
bool registered = false;
for (int i = 0; i < users.Count; i++)
{
    if (users[i] == input)
    {
        Console.WriteLine($"Username exists at index {i}");
        registered = true;
        break;
    }
}
if (!registered)
{
    Console.WriteLine("Username not registered");
}

// Exercise 5: Check intel kits

using System.Reflection;

Dictionary<string, List<string>> soldiers = new Dictionary<string, List<string>>();
soldiers["Avi"] = new List<string> {"recorder", "map", "notebook"};
soldiers["Moshe"] = new List<string> {"recorder", "map"};
soldiers["Rami"] = new List<string> {"recorder","notebook"};
foreach (string soldier in soldiers.Keys)
{
    if (soldiers[soldier].Count < 3)
    {
        Console.WriteLine($"{soldier} is missing tools.");
    }
    else
    {
        Console.WriteLine($"{soldier} is ready for intel work.");
    }
}