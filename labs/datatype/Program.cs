// using System;

// namespace Varibles{

// class Program
// {
//     static void Main(string[] args)
//     {
//         int myInt = 100;
//         double myDouble = 99.99;
//         float myFloat = 9;
//         byte myByte = 255; // if you initialize the value of byte greate than 256 it will give you an error.

//         string myString = "This is a string data type";
//         char myChar = 'A';

//         Boolean status;

//         status = true;


//         Console.WriteLine(myInt);
//         Console.WriteLine(myFloat);
//         Console.WriteLine(myByte);
//         Console.WriteLine(status);
//         Console.WriteLine(myString);
//         Console.WriteLine(myChar);


//     }
// }
// }


using System;

namespace StringType
{
    class Progarm
    {
        static void Main(String[] args)
        {
            String str = "Hello\rWorld!";

            String myString = @"Hello\rWorld!";

            int num1 = 5;
            int num2 = 4;

            Console.WriteLine($"Sum: {num1 + num2 }");
            Console.WriteLine("Sum: {0}",num1+num2);
             Console.WriteLine("Sum: " + (num1+num2));
            Console.WriteLine(str);
            Console.WriteLine(myString);
        }
    }
}

// using System;

// namespace JaggedArrayExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Declare and initialize a jagged array
//             int[][] jaggedArray = new int[3][];
            
//             jaggedArray[0] = new int[] { 1, 2, 3 };
//             jaggedArray[1] = new int[] { 4, 5 };
//             jaggedArray[2] = new int[] { 6, 7, 8, 9 };

//             // Access and display elements from the jagged array
//             Console.WriteLine("Elements of the jagged array:");
//             for (int row = 0; row < jaggedArray.Length; row++)
//             {
//                 for (int col = 0; col < jaggedArray[row].Length; col++)
//                 {
//                     Console.Write(jaggedArray[row][col] + " ");
//                 }
//                 Console.WriteLine();
//             }

//          }
//     }
// }