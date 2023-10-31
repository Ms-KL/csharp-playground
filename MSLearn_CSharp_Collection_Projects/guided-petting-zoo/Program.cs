/*

    DESIGN SPECIFICATIONS

    - There will be three visiting schools
        - School A has six visiting groups (the default number)
        - School B has three visiting groups
        - School C has two visiting groups

    - For each visiting school, perform the following tasks
        1. Randomize the animals
        2. Assign the animals to the correct number of groups
        3. Print the school name
        4. Print the animal groups

*/

using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

// call methods - required = schoolName, optional = groups
PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

void RandomizeAnimals() 
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length/groups];
    // groups = the number of animal groups you want to create. 
    // pettingZoo.Length/groups = how many animals are assigned to each group. 
    // For example, since pettingZoo is a fixed array of 18 elements, the 2D array size for School A is [6,3].
    
    int start = 0;
    
    // assign animal to each group
    for (int i = 0; i < groups; i++) 
    // for group in groups
    {
        for (int j = 0; j < result.GetLength(1); j++) 
        // for animal in group
        {
            result[i,j] = pettingZoo[start++];
            // result = name of group and animal
        }
    }

    return result;
    
}

void PrintGroup(string[,] group)
// parameter = 2d string array named group
{
    for (int i = 0; i < group.GetLength(0); i++) 
    // for group in groups in individual school
    {
        Console.Write($"Group {i + 1}: ");
        // print group number        
        for (int j = 0; j < group.GetLength(1); j++) 
        // for animal in group
        {
            Console.Write($"{group[i,j]}  ");
            // print each group then animal
        }
        Console.WriteLine();        
    }
}

// ------------------------------------
// test

// foreach(string animal in pettingZoo) 
// {
//     Console.WriteLine(animal);
// }