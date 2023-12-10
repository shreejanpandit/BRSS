

using System;

namespace BasicStructure
{
    class Program
    {
        static void Main(String[] args)
        {

            string str = "step on no pets", revstr = "";
            int len = str.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                revstr = revstr + str[i];
            }
            if (str == revstr)
            {
                System.Console.WriteLine("Palindrome!!!");
                System.Console.WriteLine("Its total length is " + len);
            }
            else
            {
                System.Console.WriteLine("Not a palindrome");
                System.Console.WriteLine("Reverse string is..... {0}", revstr);
            }
        }
    }

}

























// using System;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // float f1 = 123456.5F;
//         // double d1 = 12345678912345.5d;
//         // decimal d2 = 1.1234567891345679123456789123M;
//         // Console.WriteLine (f1);
//         // Console.WriteLine (d1);
//         // Console.WriteLine (d2);

//         // //sum of 2 numbers
//         // Console.Write("Enter the first number: ");
//         // int number1 = Convert.ToInt32(Console.ReadLine());

//         // Console.Write("Enter the second number: ");
//         // int number2 = Convert.ToInt32(Console.ReadLine());

//         // int sum = number1 + number2;
//         // Console.WriteLine($"Sum of {number1} and {number2} is: {sum}");


//         //char->int->long->float->double #Implicit
//         //double->float->long->int->char #Explicit

//         // //implicit
//         // int myInt = 9;
//         // double myDouble = myInt; //Automatically convert into double
//         // Console.WriteLine (myDouble);

//         //   //explicit  
//         // double myDouble1 = 9.78;
//         // int myInt1 = (int) myDouble1;
//         // Console.WriteLine(myInt1);

//         // //Conversion method
//         // int myInt = 10;
//         // double myDouble = 5.25;
//         // bool myBool = true;
//         // Console.WriteLine(Convert.ToString(myInt)); // convert int to string
//         // Console.WriteLine(Convert.ToDouble(myInt)); // convert int to double
//         // Console.WriteLine(Convert.ToInt32(myDouble)); // convert double to int
//         // Console.WriteLine(Convert.ToString(myBool));

//         //  string intString = "42";
//         // int parsedInt = int.Parse(intString);

//         // string floatString = "3.14";
//         // float parsedFloat = float.Parse(floatString);

//         // string longString = "1234567890123456789";
//         // long parsedLong = long.Parse(longString);

//         // string doubleString = "2.71828";
//         // double parsedDouble = double.Parse(doubleString);

//         // Console.WriteLine(parsedInt);
//         // Console.WriteLine(Convert.ToString(parsedFloat));
//         // Console.WriteLine(Convert.ToString(parsedLong));
//         // Console.WriteLine(Convert.ToString(parsedDouble));


//     }
// }



//Homework
// Mention and explain different types of operators in C#





// using System;
// namespace ArrayApplication {
//  class MyArray {
// static void Main(string[] args) {
//  int []  n = new int[10]; /* n is an array of 10 integers */
//  int i,j;
//  /* initialize elements of array n */
//  for ( i = 0; i < 10; i++ ) {
//     n[ i ] = i + 100;
//  }

//  /* output each array element's value */
//  for (j = 0; j < 10; j++ ) {
//     Console.WriteLine("Element[{0}] = {1}", j,n[j]);
//  }
// //     Console.WriteLine();
// //   for (j = 0; j < 10; j++ ) {
// //     Console.WriteLine("Element[" + j +"] = " + n[j]);
// //  }

// }
//  }
// }
