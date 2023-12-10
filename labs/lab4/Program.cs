using System;

namespace SwitchCase
{
    class Switchcase
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Your Day:");



            int day_num = Convert.ToInt32(Console.ReadLine());

            switch (day_num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid day");
                    break;
            }



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


// //Fibonacci sequence  0 1 1 2 3 5 8 13
//             int n = 15;
//             int a = 0, b = 1,temp;
//             System.Console.WriteLine("Fibonacci series");
//             for (int i = 0; i < n; i++)
//             {
//                 System.Console.Write(a + " ");
//                  temp = a;
//                 a = b;
//                 b = temp + a;
//             }

           
        }
    }


}