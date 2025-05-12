// Loops

// Easy

// 1. for loop that print numbers from 1 to 5
for (int i = 1; i < 6; i++)
{
    Console.WriteLine(i);
}

// 2. while loop that print even numbers from 2 to 10
int i = 2;
while (i < 11)
{
    Console.WriteLine(i);
    i += 2;
}

// 3. check if input is positive
Console.WriteLine("Enter a number:");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(num > 0 ? "Positive" : "Not positive");

// 4. Infinite loop untill user entered end
string input;
do
{
    Console.WriteLine("Enter any input. 'end' to stop the loop");
    input = Console.ReadLine();
}
while (input != "end");

// 5. print 10 times the massege: Authorized access
for (int i = 0; i < 5; i++) ;
{
    Console.WriteLine("Authorized access");
}

// 6. print the numbers from 1 to 20 that are not divided by 3
for (int i = 1; i < 21; i++)
{
    if (i % 3 != 0)
    {
        Console.WriteLine($"{i} doesn't divided by 3");
    } 
}

// 7. count from 5 to 1
int i = 5;
while (i > 0)
{
    Console.WriteLine(i);
    i--;
}

// 8. go from 1 to 10 and check if the number is even or odd
for (int i = 1; i < 11; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} is Even number");
    }
    else
    {
        Console.WriteLine($"{i} is Odd number");
    }
}

// 9. check if input is 8200
string input;
do
{
    Console.WriteLine("Enter input. if it is 8200 you will see: Sure!");
    input = Console.ReadLine();
}
while (input != "8200");
Console.WriteLine("Sure!");

// 10. check if input is admin
string input = "";
while (input != "admin")
{
    Console.WriteLine("Enter input. if you will wnter 'admin' it will stop");
    input = Console.ReadLine();
}

// Medium

// 11. count numbers from 1 to 100 that divided by 7
int counter = 0;
List <int> numbers = new List<int>();

for (int i = 1; i < 101; i++)
{
    if (i % 7 == 0)
    {
        numbers.Add(i);
        counter++;
    }
}
Console.WriteLine($"There are {counter} numbers from 1 to 100 that divided by 7:");
foreach (int num in numbers)
{
    Console.WriteLine(num);
	
// 12. check if password's length is 8 characters
Console.WriteLine("Enter password:");
string password = Console.ReadLine();
int counter = 0;
foreach (char ch in password)
{
    counter++;
}
Console.WriteLine($"The length is {counter} characters");

// 13. print letters of a string
Console.WriteLine("Enter a string:");
string str = Console.ReadLine();
Console.WriteLine("The letters are:");
foreach (char ch in str)
{
    if (Char.IsLetter(ch))
    {
        Console.WriteLine(ch);
    } 
}

// 14. while loop untill the password's length is 8
string password = "";
while (password.Length < 8)
{
    Console.WriteLine("Enter password:");
    password = Console.ReadLine();
}
Console.WriteLine("Great! strong password.");

// 15. check from 1 to n if number is a prime
Console.WriteLine("Enter number for scope:");
int scope = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= scope; i++)
{
    bool isPrime = true;
    for (int j = 2; j <= Math.Sqrt(i); j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
            }
        }
    Console.WriteLine(isPrime ? $"{i} is a prime.": $"{i} is not a prime.");
}

// Advanced

// 21. varify user by compering username and password
string username = "user@gmail.com";
string password = "A!b@c$D5";
Console.WriteLine("Enter username:");
string usernameInput = Console.ReadLine();
Console.WriteLine("Enter password:");
string passwordInput = Console.ReadLine();
Console.WriteLine(username == usernameInput && password == passwordInput ? "Varified!" : "Wrong username or password!");

// 22. random password
Random rnd = new Random();
string password = "";

for (int i = 0; i < 6; i++)
{
    password += Convert.ToString(rnd.Next(10));
}
Console.WriteLine($"created password: {password}");

// 23. check if password included numbers and characters
Console.WriteLine("Enter password:");
string password = Console.ReadLine();
bool thereIsC = false;
bool thereIsN = false;
foreach (char ch in password)
{
    if (Char.IsDigit(ch))
        {
        thereIsN = true;
    }
    else
    {
        thereIsC = true;
    }
}
if (thereIsC && thereIsN)
{
    Console.WriteLine("password with numbers and characters");
}
else if (thereIsC)
{
    Console.WriteLine("password with characters only");
}
else
{
    Console.WriteLine("password with numbers only");
}

// 24. change digits in a string to the word 'number'
Console.WriteLine("Enter a string:");
string str = Console.ReadLine();
string newStr = "";
foreach (char ch in str)
{
    if (Char.IsDigit(ch))
    {
        newStr += " number ";
    }
    else
    {
        newStr += ch;
    }
}
Console.WriteLine(newStr);


// 25. check if password with 8 or 2 or 0
Console.WriteLine("Enter the password:");
string password = Console.ReadLine();
bool isThere = false;
foreach (char ch in password)
{
    if (ch == '8' || ch == '2' || ch == '0')
    {
        isThere = true;
    }
}
Console.WriteLine(isThere ? "There is 8 or 2 or 0" : "There is not 8 or 2 or 0");