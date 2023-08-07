// TUTORIAL: https://www.linkedin.com/learning/learning-c-sharp-8581491/variables-and-data-types

using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some basic value type variables
            // specifies type of variable to prevent errors
            int example_i = 10;
            float example_f = 2.0f;
            decimal example_d = 10.0m;
            bool example_b = true;
            char example_c = 'c';

            // Declare a string - it's a collection of characters
            string example_str = "a string";

            // Declare an implicit variable (like in javascript)
            // figures out type based on value (eg int or string)
            var example_x = 10;
            var example_z = "Hello!";

            // TODO: Declare an array of values
            // create an array of 5x integer values

            int[] example_vals = new int[5];
            Console.WriteLine(example_vals);
            // ! PRINTS: System.Int32[] (array of integers)
            // due to empty array, prints type of array
            // int [] = empty array (of integers)
            // example_vals = variable name of array
            // new int[5] = new array of 5x integers

            string[] example_strs = { "one", "two", "three" };
            Console.WriteLine(example_strs);
            // ! PRINTS: System.String[] (array of strings)
            // due to empty array, prints type of array
            // string [] = empty array (of strings)
            // example_strs = variable name of array
            // { "one", "two", "three" } = new array of 3x strings

            // TODO: Print the values using a Formatting String
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", example_i, example_f, example_d, example_b, example_c, example_str, example_x, example_z);
            // ! PRINTS: 10,2,10,True,c,a string,10,Hello!
            // {0} = placeholder for first value
            // {0},{1},{2},{3},{4},{5},{6},{7} = 8x placeholders
            // example_i, example_f, example_d, example_b, example_c, example_str, example_x, example_z = 8x values to be printed in the placeholders

            // TODO: "null" means "no value"
            object example_obj = null;
            Console.WriteLine(example_obj);
            // ! PRINTS: nothing (no value)
            // set variable example_obj to null (no value)

            // TODO: Implicit conversion between types
            long example_bignum;
            example_bignum = example_i;
            // example_bignum type = long
            // example_i type = int
            // use " = " to convert int to long

            // TODO: Explicit conversions
            float examplei_to_f = (float)example_i;
            // Console.WriteLine(examplei_to_f);
            Console.WriteLine("{0}", examplei_to_f);
            // converts example_i (int) to float (10 to 10.0)

            float examplef_to_i = (int)example_f;
            Console.WriteLine("{0}", examplef_to_i);
            // converts example_f (float) to int (2.0 to 2)


        }
    }
}
