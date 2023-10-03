# [Learn C# MS Learn Collection Projects](https://learn.microsoft.com/en-us/users/dotnet/collections/yz26f8y64n7k07) <br> via MS Learn & FreeCodeCamp

Learning C# via MS Learn & FreeCodeCamp Cirriculum

* Note: Snippets & Study Notes located: [CSharp Notebook](.\mslearn_Csharp_studynotes.ipynb) & throughout projects
* Created using [Polygot Notebooks](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode) to edit in C#


-------------------------------------------------------------------------------
## Setup steps    

1. create a new console application
    ```shell
    dotnet new console -o ./CsharpProjects/TestProject
    ```
    - This .NET CLI command uses a .NET program template to:
        - create a new C# console application project in the specified folder location
        - create the `CsharpProjects` and `TestProject` folders
        - use `TestProject` as the name of your `.csproj` file.

    * It also creates `Program.cs` and inserts: 
        ```csharp
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        // legacy version 5.0 and prior
        legacy version 5.0 and prior
        using System;

        namespace MyApp // Note: actual namespace depends on the project name.
        {
            internal class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Hello World!");
                }
            }
        }
        ```
2. edit Program.cs
    ```csharp
    Console.WriteLine("Kristy is learning C#");
    ```
3. Right click TestProject directory in VS Code - Open Integrated Terminal
4. run `dotnet build` command to build project and dependency into binaries
    ```shell
    dotnet build
    ```
5. run application in terminal
    ```shell
    dotnet run
    ```
6. update `Project.cs` as required

--------------------------------------------------------------------------------


