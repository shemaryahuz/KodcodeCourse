// Conditions


//basic

// 1. Get number and print if the number negative or positive
Console.WriteLine("Enter a number:");
string numS = Console.ReadLine();
double numD = Convert.ToDouble(numS);
Console.WriteLine(numD > 0 ? "Positive" : "Negative");

// 2. Get two numbers and print the greater
Console.WriteLine("Enter a number 1:");
string num1S = Console.ReadLine();
double num1D = Convert.ToDouble(num1S);
Console.WriteLine("Enter a number 2:");
string num2S = Console.ReadLine();
double num2D = Convert.ToDouble(num2S);
if (num1D > num2D)
{
    Console.WriteLine(num1D + " is greater");
}        
else if (num1D < num2D)
{
    Console.WriteLine(num2D + " is greater");
}
else
{
    Console.WriteLine("The numbers are equal");
}

// 3. Get a grade and print: Excellent from 90 on, Very good from 75 to 89, Needs improvement else
Console.WriteLine("Enter a grade:");
string gradeS = Console.ReadLine();
int gradeI = Convert.ToInt32(gradeS);
if (gradeI > 89)
{
    Console.WriteLine("Excellent");
}        
else if (gradeI > 74 && gradeI < 90)
{
    Console.WriteLine("Very good");
}
else
{
    Console.WriteLine("Needs improvement");
}

// 4. Get a day in number and print the day in name
Console.WriteLine("Enter a day in number:");
string dayS = Console.ReadLine();
int dayI = Convert.ToInt32(dayS);
switch (dayI)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednsday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Shabbat");
        break;
}

// 5. Get a temperature and print: Hot from 30 on, Nice from 20 to 29, Cold else
Console.WriteLine("Enter the temperature:");
string temperatureS = Console.ReadLine();
int temperatureI = Convert.ToInt32(temperatureS);
if (temperatureI > 30)
{
    Console.WriteLine("Hot");
}
else if (temperatureI > 20 && temperatureI < 29)
{
    Console.WriteLine("Nice");
}
else
{
    Console.WriteLine("Cold");
}

// 6. Get an age. if it is from 17 on print: Can issue a license. else: Not yet
Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());
Console.WriteLine(age > 16 ? "Can issue a license" : "Not yet");

// 7. Get a number and print even or Odd
Console.WriteLine("Enter a number:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");

// 8. Get a Character and print Lowercese or Uppercase or Not a letter
Console.WriteLine("Enter a character:");
char chr = Console.ReadLine()[0];
Console.WriteLine(Char.IsLetter(chr) ? Char.IsLower(chr) ? "Lowercese": "Uppercase" : "Not a letter");

// 11. Get year of birth and print the age

Console.WriteLine("Enter year of birth");
int year = Convert.ToInt32(Console.ReadLine());
int age = 2025 - year;
string title = "";
if (age < 13)
{
    title = " child";
}
else if (age > 12 && age < 18)
{
    title = " Boy";
}
else if (age > 17)
{
    title = "n Adult";
}
Console.WriteLine($"You are a{title}, {age} years old.");

// 12. Get 3 numbers and print the greater


Console.WriteLine("Enter number 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 3:");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 >= num3)
    {
        Console.WriteLine($"{num1} is the great");
    }
}