# C# Playground

## Description

This repo explores the fundamentals of C# Programming via tutorials and documentation.

## Resources

### ["Learn C#" Collection ](https://learn.microsoft.com/en-us/users/dotnet/collections/yz26f8y64n7k07) by MS Learn & FreeCodeCamp

- See: [MSLearn CSharp Collection Projects](./MSLearn_CSharp_Collection_Projects) for my repo

### ["Learning C#" LinkedIn Learning Course](https://www.linkedin.com/learning/learning-c-sharp-8581491) by [Joe Marini](https://www.linkedin.com/learning/.instructors/joe-marini)

- see: [ExerciseFiles](./ExerciseFiles) for mu repo

## Create a new project

1. cd to the directory where you want to create the project
2. dotnet new console <project_name>

   - eg. `dotnet new console HelloWorld` (output simple hello world program)
     - alt: `dotnet new console --use-program-main` (to reflect [tutorial issue](https://www.linkedin.com/learning/questions/not-so-much-a-question-but-a-tip-for-people-running-newer-dot-net-or-vs-than-this-course-covers-6-or-7-plus-i-7091214048079306752))
   - creates:

     - obj folder
     - Program.cs # where the code goes
     - structure:

       Simple Hello World Program:

       ```c#
       using System;
       Console.WriteLine("Hello World!");
       ```

       OR using a class (encapsulation)

       ```c#
       using System;
       namespace HelloWorld
       {
           class Program
           {
               static void Main(string[] args)
               {
                   Console.WriteLine("Hello World!");
               }
           }
       }
       ```

     - HelloWorld.csproj

3. dotnet run
4. dotnet build
