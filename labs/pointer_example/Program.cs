// namespace pointer_example;

// class Program
// {
//     public static void Main()
//     {
//         unsafe
//         {
//             int var = 100;
//             int* p = &var;
//             Console.WriteLine("Address of var is  is: {0} ", (uint)&var);
//             Console.WriteLine("Data of var is: {0} ", var);
//             Console.WriteLine("Data of p is: {0} ", (uint)p);
//             Console.WriteLine("value the pointer refrence is  {0} ", *p);
//         }
//     }
// }


// using System;

// namespace UnsafeCodeApplication {
//     class Program {
//         public static void Main() {
//             unsafe {
//                 int var = 100;
//                 int* p = &var;
//                 Console.WriteLine("Data is: {0} ", var);
//                 Console.WriteLine("Data is: {0} ", p->ToString());
//                 Console.WriteLine("Data is: {0} ", *p);
//                 Console.WriteLine("Address is: {0} ", (int)p);
//             }
//             Console.ReadKey();
//         }
//     }
// }


// //swap value without pointer

// using System;
// namespace Program{
//     class TestPointer{
//         public void swap(int p, int q){
//             int temp = p;
//             p=q;
//             q=temp;
//              System.Console.WriteLine($"After swap: var1: {p} var2: {q}");
//         }

//         public unsafe static void Main(){
//             TestPointer p= new TestPointer();
//             int var1 = 20;
//             int var2 = 10;
//             System.Console.WriteLine($"Before swap: var1: {var1} var2: {var2}");

//             p.swap(var1,var2);
//             System.Console.WriteLine($"After  swap in main: var1: {var1} var2: {var2}");

//         }
//     }
// }


// //swap value using pointer

// using System;
// namespace Program{
//     class TestPointer{
//         public unsafe void swap(int *p, int *q){
//             int temp = *p;
//             *p=*q;
//             *q=temp;
//         }

//         public unsafe static void Main(){
//             TestPointer p= new TestPointer();
//             int var1 = 20;
//             int var2 = 10;

//             int *x = &var1;
//             int *y = &var2;

//             System.Console.WriteLine($"Before swap: var1: {var1} var2: {var2}");

//             p.swap(x,y);
//             System.Console.WriteLine($"After swap: var1: {var1} var2: {var2}");
//         }
//     }
// }



//fixed string type

// using System;

// class Program
// {
//     static unsafe void Main()
//     {
//         string myString = "Hello World";

//         // Use fixed to get a pointer to the first character of the string
//         fixed (char* ptr = myString)
//         {
//             // Access each character using the pointer
//             for (int i = 0; i < myString.Length; i++)
//             {
//                 Console.Write(*(ptr + i)); 
//                     // Dereference the pointer to get the character
//             }

//         }
//     }
// }

using System;
namespace ArrayAccessWithPointer
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            fixed (int* p = numbers)
            {
                // Accessing array elements using a pointer
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Element {i + 1}: {*(p + i)}");
                }
            }
        }
    }
}