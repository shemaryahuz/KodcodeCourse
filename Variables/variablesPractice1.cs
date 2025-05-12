//Code practice:

//26
int x = 5;

//27
string name = "Moshe";
Console.WriteLine("Hello " + name);

//28
int num1 = 1;
int num2 = 2;
int result = num1 + num2;

//29
double x = 5.5;
double y = 8.2;
double average = (x + y) / 2;

//30
Console.WriteLine("Enter Birthday greeting:");
string greeting = Console.ReadLine();
Console.WriteLine("The greeting's length is " + greeting.Length + " characters");

//31
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Enter your age:");
string ageS = Console.ReadLine();
int ageI = Convert.ToInt32(ageS);
Console.WriteLine("Hello " + name + "! In 5 years you will be " + (ageI + 5) + " years old");

//32
Console.WriteLine("Enter a string to display:");
string str = Console.ReadLine();
Console.WriteLine("Enter a number for times:");
string timesS = Console.ReadLine();
int timesI = Convert.ToInt32(timesS);
Console.WriteLine(String.Concat(Enumerable.Repeat(str, timesI)));

//33
Console.WriteLine("Enter number 1:");
string num1s = Console.ReadLine();
double num1d = Convert.ToDouble(num1s);
Console.WriteLine("Enter number 2:");
string num2s = Console.ReadLine();
double num2d = Convert.ToDouble(num2s);
Console.WriteLine("Enter number 3:");
string num3s = Console.ReadLine();
double num3d = Convert.ToDouble(num3s);
double average = (num1d + num2d + num3d) / 3;
Console.WriteLine("The average is: " + average);

//34
Console.WriteLine("Enter a string:");
string str = Console.ReadLine();
string strU = str.ToUpper();
Console.WriteLine(strU);

//35
Console.WriteLine("Enter age:");
string ageS = Console.ReadLine();
int ageI = Convert.ToInt32(ageS);
if (ageI < 18)
{
    Console.WriteLine("Prohibited");
}
else
{
    Console.WriteLine("Allowed");
}

//36
string numS = "10";
int numI = Convert.ToInt32(numS);
Console.WriteLine(numI);

//37
Console.WriteLine("Enter string 1:");
string str1 = Console.ReadLine();
Console.WriteLine("Enter string 2:");
string str2 = Console.ReadLine();
if (str1 == str2)
{
    Console.WriteLine("Equal");
}
else
{
    Console.WriteLine("Not equal");
}

//38
Console.WriteLine("Enter a number:");
string numS = Console.ReadLine();
int numI = Convert.ToInt32(numS);
if (numI % 2 == 0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("Odd number");
}

//39
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
if (name.StartsWith("A"))
{
    Console.WriteLine("Your name start with A");
}
else
{
    Console.WriteLine("Your name doesn't start with A");
	
//40
Console.WriteLine("Enter number:");
string numS = Console.ReadLine();
double numD = Convert.ToDouble(numS);
double result = Math.Pow(numD, 2);
Console.WriteLine($"Result: {result}");

//41
Console.WriteLine("Enter your height in centimeters:");
string heightS = Console.ReadLine();
double heightD = Convert.ToInt32(heightS);
Console.WriteLine($"Your height in centimeters is {heightD}");
Console.WriteLine($"Your height in inches is {heightD / 2.54}");

//42
Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
double num;

if (double.TryParse(input, out num))
{
    Console.WriteLine("Valid input");
}
else
{
    Console.WriteLine("Invalid input");
}

//43
Console.WriteLine("Enter number 1:");
string num1S = Console.ReadLine();
double num1D = Convert.ToDouble(num1S);

Console.WriteLine("Enter number 2:");
string num2S = Console.ReadLine();
double num2D = Convert.ToDouble(num2S);

Console.WriteLine("Enter a shape (Rectangle or Triangle):");
string shape = Console.ReadLine();

if (shape == "Rectangle" || shape == "Triangle")
{
    Console.WriteLine($"The shape's erea is {num1D * num2D}");
}
else
{
    Console.WriteLine("Invalid input");
}


//44
Console.WriteLine("Enter your full name:");
string name = Console.ReadLine();

string[] fullName = name.Split(" ");

string lastName = fullName[fullName.Length - 1];

Console.WriteLine($"Your last name is: {lastName}");

//45
Console.WriteLine("Enter number 1:");
string num1S = Console.ReadLine();
double num1D = Convert.ToDouble(num1S);

Console.WriteLine("Enter number 2:");
string num2S = Console.ReadLine();
double num2D = Convert.ToDouble(num2S);

if (Math.Pow(num2D, 2) == num1D)
{
    Console.WriteLine("Number 1 is the square of number 2");
}
else
{
    Console.WriteLine("Number 1 is not the square of number 2");
}
