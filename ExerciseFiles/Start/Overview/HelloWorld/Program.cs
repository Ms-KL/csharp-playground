// TUTORIAL: https://www.linkedin.com/learning/learning-c-sharp-8581491/hello-world-c-sharp

// -- old version

// using System; // in tutorial: using .net system namespace

// namespace HelloWorld; // prevent colliding names with other namespaces

// class Program // class is a container for data and methods
// {
//     static void Main(string[] args) // void: no return value
//     {
//         Console.WriteLine("Hello, World!");
//         Console.WriteLine("What is your name?");
//         string inputName = Console.ReadLine();
//         Console.WriteLine("Hello there, " + inputName + "!");
//     }
// }

// -- efficient alternative to above:

using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("What is your name?");
string inputName = Console.ReadLine();
Console.WriteLine("Hello there, " + inputName + "!");
