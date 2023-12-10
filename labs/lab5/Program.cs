namespace lab5;

class Program
{
    static void Main(string[] args)
    {

        //Fibonacci sequence  0 1 1 2 3 5 8 13
        int n = 15;
        int a = 0, b = 1, temp;
        System.Console.WriteLine("Fibonacci series");
        for (int i = 0; i < n; i++)
        {
            System.Console.Write(a + " ");
            temp = a;
            a = b;
            b = temp + a;
        }

        // Exam question : : Palindrome
        //  string str = "step on no pets", revstr = "";
        //     int len = str.Length;

        //     for (int i = len - 1; i >= 0; i--)
        //     {
        //         revstr = revstr + str[i];
        //     }
        //     if (str == revstr)
        //     {
        //         System.Console.WriteLine("Palindrome!!!");
        //         System.Console.WriteLine("Its total length is " + len);
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Not a palindrome");
        //         System.Console.WriteLine("Reverse string is..... {0}", revstr);
        //     }

        //Palindrome number
        // int number, rem, rev=0;
        // int temp;
        // System.Console.WriteLine("Enter number");
        // number= Convert.ToInt32(Console.ReadLine());
        // temp=number;
        // while(temp!=0){
        //     rem = temp % 10;
        //     rev = rev * 10 + rem;
        //     temp = temp /10;
        // }
        // if (number==rev){
        //     System.Console.WriteLine("Palindrome");
        // }else
        // {
        //     System.Console.WriteLine("Not Palindrome");
        // }
        // {
            
        // }
    }
}
