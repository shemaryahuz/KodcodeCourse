// Arithmetic operators

// Int & Double

var a = 5 + "";
Console.WriteLine(a.GetType()); // Double

var b = 3.5 - 4;
Console.WriteLine(b.GetType()); // Double

var c = 2.8 / 2;
Console.WriteLine(c.GetType()); // Double

var d = 7 * 1.5;
Console.WriteLine(d.GetType()); // Double

// Int & String

var a = 5 + "hello";
Console.WriteLine(a.GetType()); // String

var b = "hello" - 4;
Console.WriteLine(b.GetType()); // Eror

var c = "hello" / 2;
Console.WriteLine(c.GetType()); // Eror

var d = 7 * "hello";
Console.WriteLine(d.GetType()); // Eror

// Int & Bool

var a = 5 + true;
Console.WriteLine(a.GetType()); // Eror

var b = false - 4;
Console.WriteLine(b.GetType()); // Eror

var c = false / 2;
Console.WriteLine(c.GetType()); // Eror

var d = 7 * true;
Console.WriteLine(d.GetType()); // Eror

// String & Bool

var a = "hello" + true;
Console.WriteLine(a.GetType()); // String

var b = false - "hello";
Console.WriteLine(b.GetType()); // Eror

var c = false / "hello";
Console.WriteLine(c.GetType()); // Eror

var d = 7 * "hello";
Console.WriteLine(d.GetType()); // Eror


// Logical operators


