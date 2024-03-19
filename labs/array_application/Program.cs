//1d array example

// using System;
// namespace ArrayApplication
// {
//     class MyArray
//     {
//         static void Main(string[] args)
//         {
//             int[] n = new int[10]; /* n is an array of 10 integers */
//             int i, j;
//             /* initialize elements of array n */
//             for (i = 0; i < 10; i++)
//             {
//                 n[i] = i + 100;
//             }

//             /* output each array element's value */
//             for (j = 0; j < 10; j++)
//             {
//                 Console.WriteLine("Element[{0}] = {1}", j, n[j]);
//             }
//             //     Console.WriteLine();
//             //   for (j = 0; j < 10; j++ ) {
//             //     Console.WriteLine("Element[" + j +"] = " + n[j]);
//             //  }

//         }
//     }
// }


//multi-dimensional array example

// using System;
// namespace ArrayApplication
// {
//     class MyArray
//     {
//         static void Main(string[] args)
//         {
//             int[,] twoDimensionalArray = new int[3, 4];
//             // Create a 2D array with 3 rows and 4 columns
//             int value = 1;
//             // Initialize elements of the 2D array
//             for (int row = 0; row < 3; row++)
//             {
//                 for (int col = 0; col < 4; col++)
//                 {
//                     twoDimensionalArray[row, col] = value;
//                     value++;
//                 }
//             }
//             // Output each array element's value
//             for (int row = 0; row < 3; row++)
//             {
//                 for (int col = 0; col < 4; col++)
//                 {
//                     Console.WriteLine("Element[{0},{1}] = {2}", row, col, twoDimensionalArray[row, col]);
//                 }
//             }
//         }
//     }
// }

//Jagged array
using System;

namespace JaggedArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a jagged array
            int[][] jaggedArray = new int[3][];
            
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            // Access and display elements from the jagged array
            Console.WriteLine("Elements of the jagged array:");
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }

         }
    }
}


//param array
// using System;

// namespace params_array
// {
//     class Program
//     {
//         static int Add(params int[] allNumbers)
//         {
//             int sum = 0;
//             foreach (int n in allNumbers)
//             {
//                 sum += n;
//             }
//             return sum;
//         }

//         static void Main(string[] args)
//         {
//             int sum;

//             // Passing three parameters
//             sum = Add(1, 2, 3);
//             Console.WriteLine("Sum of 1, 2, 3 is:\t{0}", sum);

//             // Passing five parameters
//             sum = Add(3, 5, 2, 6, 2);
//             Console.WriteLine("Sum of 3, 5, 2, 6, 2 is:\t{0}", sum);
//         }
//     }
// }
