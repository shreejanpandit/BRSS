
class Program
{
    static void Main(string[] args)
    {

        String fname, lname;
        fname = "Brad ";
        lname = "Pitt";
        char[] letters = { 'W', 'e', 'b' };

        string[] sarray = { "Web", "World" };

        //from string literal and string concatenation
        string fullname = fname + lname;
        Console.WriteLine("Full Name: {0}", fullname);

        //by using string constructor { 'W, 'e', 'b'};
        string greetings = new string(letters);
        Console.WriteLine("Greetings: {0}", greetings);

        //methods returning string { "Web", "World" };
        string message = String.Join(" ", sarray);
        Console.WriteLine("Message: {0}", message);

        //formatting method to convert a value
        DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
        string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
        Console.WriteLine("Message: {0}", chat);

    }
}
