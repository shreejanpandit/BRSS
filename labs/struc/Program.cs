// using System;
// struct Books {
//    public string title;
//    public string author;
//    public string subject;
//    public int book_id;
// };  

// public class testStructure {
//    public static void Main(string[] args) {
//       Books Book1;   /* Declare Book1 of type Book */
//       Books Book2 = new Books();   // Declare Book2 of type Book 

//       /* book 1 specification */
//       Book1.title = "C Programming";
//       Book1.author = "Nuha Ali"; 
//       Book1.subject = "C Programming Tutorial";
//       Book1.book_id = 6495407;

//       /* book 2 specification */
//       Book2.title = "Telecom Billing";
//       Book2.author = "Zara Ali";
//       Book2.subject =  "Telecom Billing Tutorial";
//       Book2.book_id = 6495700;

//       /* print Book1 info */
//       Console.WriteLine( "Book 1 title :"+Book1.title);
//       Console.WriteLine("Book 1 author : {0}", Book1.author);
//       Console.WriteLine("Book 1 subject : {0}", Book1.subject);
//       Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

//       /* print Book2 info */
//       Console.WriteLine("Book 2 title : {0}", Book2.title);
//       Console.WriteLine("Book 2 author : {0}", Book2.author);
//       Console.WriteLine("Book 2 subject : {0}", Book2.subject);
//       Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);       
//    }
// }
/*.......................................................................*/
// structure using constructor

// using System;

// struct Books {
//    public string title;
//    public string author;
//    public string subject;
//    public int book_id;

//   public Books(string t, string a, string s, int id){
//     title=t;
//     author=a;
//     subject=s;
//     book_id=id;
//    }

//    public void display(){
//     System.Console.WriteLine("title is :"+this.title);
//     System.Console.WriteLine("author is :"+this.author);
//     System.Console.WriteLine("subject is :"+this.subject);
//     System.Console.WriteLine("book_id is :"+this.book_id);
//    }
// };  

// public class testStructure {
//    public static void Main(string[] args) {
//       Books Book1 = new Books("C","sh", "testtt",321);   // Declare Book1 of type Book
//       Books Book2 = new Books("C++","shree", "test",123);   /* Declare Book2 of type Book */
//       Book1.display();
//       Book2.display();     
//    }
// }

/* ...........................................................*/
// structure using method to set and get value

using System;
struct Books {
   public string title;
   public string author;
   public string subject;
   public int book_id;

  public void setValue(string t, string a, string s, int id){
    title=t;
    author=a;
    subject=s;
    book_id=id;
   }

   public void display(){
    System.Console.WriteLine("title is :"+this.title);
    System.Console.WriteLine("author is :"+this.author);
    System.Console.WriteLine("subject is :"+this.subject);
    System.Console.WriteLine("book_id is :"+this.book_id);
   }
};  
public class testStructure {
   public static void Main(string[] args) {
      Books Book1= new Books();    // Declare Book1 of type Book
      Books Book2 = new Books();   /* Declare Book2 of type Book */
      Book1.setValue("learning c","hari","C programming",1232);
      Book2.setValue("learning cpp","harilal","Cpp programming",3121);
      Book1.display();
      Book2.display();
   }
}



// Write a c# structure program to store a 2 different student details
//(Name,Address, Roll No, Hobbies, gender etc);
// Also instiate with the new keyword.