﻿// using System;

// namespace BasicStructure
// {
//     class Program
//     {
//         static void Main (String[] args)
//         {
//             //my first prgram in C#
//             Console.WriteLine("Hello World");
//             Console.Write("Hello Shreejan ");
//             Console.Write("Pandit");

//         }
//     }
        
// }

// Write a for loop that prints all the even numbers from 0 to 20.
using System;

class Program
{
    static void Main()
    {
         Console.WriteLine("Enter your marks");
         int grade= Convert.ToInt32(Console.ReadLine());
         
        switch (grade/10)
        {
            case 10:
           
            case 9:
                Console.WriteLine("A");
                break;
            case 8:
                Console.WriteLine("B");
                break;
            case 7:
                Console.WriteLine("C");
                break;
            case 6:
                Console.WriteLine("D");
                break;
            default:
                Console.WriteLine("F");
                break;
        }
    }
}


namespace HelloWorld 
{ class Program 
{ static void Main(string[] args) { 
    /* comment */  // orcomment 
    Console.WriteLine("Hello World!"); 
}
}
}