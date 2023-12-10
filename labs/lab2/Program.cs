// using System;
// namespace JaggedArrayExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Declare and initialize a jagged array
//             int[][] jaggedArray = new int[4][];
//             jaggedArray[0] = new int[] { 1, 2, 3 };
//             jaggedArray[1] = new int[] { 4, 5 };
//             jaggedArray[2] = new int[] { 6, 7, 8, 9 };
//             jaggedArray[3] = new int[] { 5, 7, 6, 9,2,1,3 };
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
//         }
//     }
// }





// using System;
// namespace params_array
// {
//     class Program
//     {
//      static   int Add(params int[] allNumbers)
//         {
//             int sum = 1;
//             foreach (int n in allNumbers)
//             {
//                 sum += n;
//             }
//             return sum;
//         }
//         static void Main(string[] args)
//         {
//             int sum;
//             // Program program = new Program();
//             // Passing three parameters
//             // sum = program.Add(1, 2, 3);
//             // Console.WriteLine("Sum of 1, 2, 3 is:\t{0}", sum);
//             // Passing five parameters
//             sum = Add(3, 5, 2, 6, 2);
//             Console.WriteLine("Sum of 3, 5, 2, 6, 2 is:{0}", sum);
//             sum = Add(3, 5);
//             Console.WriteLine("Sum of 3, 5 is:{0}", sum);
//             sum = Add();
//             Console.WriteLine("Sum of nothing is:{0}", sum);
//         }
//     }
// }



using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an array of integers
            int[] numbers = { 5, 10, 15, 20, 25 };

            // Getting the length of the array
            int arrayLength = numbers.Length;
            Console.WriteLine("Array length: " + arrayLength);

            // Using IsReadOnly property
            Console.WriteLine("Is array read-only? " +  numbers.IsReadOnly);

            // Using IsFixedSize property
            Console.WriteLine("Is array fixed size? " +  numbers.IsFixedSize);

            // Using Rank property
            Console.WriteLine("Array rank (number of dimensions): " + numbers.Rank);

            // Sorting the array
            Array.Sort(numbers);

            // Displaying sorted array
            Console.WriteLine("Sorted array elements:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}





// using System;

// namespace ArrayExample
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating an array
//             int[] dynamicArray = new int[5];

//             // Checking if the array has a fixed size
//             Console.WriteLine("Is array fixed-size? " + dynamicArray.IsFixedSize); // Outputs: False

//             // Modifying elements in the dynamic array
//             dynamicArray[0] = 10;
//             dynamicArray[1] = 20;
//             dynamicArray[2] = 30;
//             dynamicArray[3] = 40;
//             dynamicArray[4] = 50;

//             // Displaying array elements
//             Console.WriteLine("Array elements:");
//             foreach (int num in dynamicArray)
//             {
//                 Console.WriteLine(num);
//             }
//         }
//     }
// }
