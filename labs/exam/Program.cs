
using System;

class MatrixAddition
{
    static void Main()
    {
        // Input for the first matrix
        int[,] value1 = new int[3, 3];
        Console.WriteLine("Enter values for Matrix 1 (3x3):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter value for element at position ({i + 1},{j + 1}): ");
                value1      [i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Input for the 2nd matrix
        int[,] value2 = new int[3, 3];
        Console.WriteLine("Enter values for Matrix 2 (3x3):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter value for element at position ({i + 1},{j + 1}): ");
                value2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // Addition of matrices
        int[,] result = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = value1[i, j] + value2[i, j];
            }
        }

        // Displaying the result
        Console.WriteLine("\nResultant Matrix (Matrix 1 + Matrix 2):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{result[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}


    
    /* 
    using System;

class Program
{
    static void Main()
    {
        // Example of a while loop
        Console.WriteLine("While Loop Example:");
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }

        // Example of a do-while loop
        Console.WriteLine("\nDo-While Loop Example:");
        int j = 1;
        do
        {
            Console.WriteLine(j);
            j++;
        } while (j <= 5);
    }
}
    
    */



    /*
using System;

class Program
{
    static void Main()
    {
        // Declare and initialize variables
        int intValue1 = 10;
        int intValue2 = 5;
        double doubleValue1 = 7.5;

        // Perform operations with variables
        int sum = intValue1 + intValue2;
        double product = intValue1 * doubleValue1;

        // Display the results
        Console.WriteLine($"Sum of {intValue1} and {intValue2} is: {sum}");
        Console.WriteLine($"Product of {intValue1} and {doubleValue1} is: {product}");

        // Type conversion examples
        double result = intValue1 / (double)intValue2; // Using casting for type conversion
        int roundedResult = (int)Math.Round(result); // Using explicit conversion

        Console.WriteLine($"Result of division (double): {result}");
        Console.WriteLine($"Rounded result: {roundedResult}");

        // Different operators
        int modulusResult = intValue1 % intValue2;
        int incrementResult = intValue1++;
        int decrementResult = intValue2--;

        Console.WriteLine($"Modulus of {intValue1} and {intValue2} is: {modulusResult}");
        Console.WriteLine($"Increment result (post-increment): {incrementResult}");
        Console.WriteLine($"Decrement result (post-decrement): {decrementResult}");
    }
}

    */