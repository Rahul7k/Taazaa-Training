using System;

struct Employees {
   public string Name;
   public string Email;
   public int Id;
};  

public class testStructure {
   public static void Main(string[] args) {
      Employees Emp1;   // Declare Emp1 
      Employees Emp2;

      // emp 1 specification
      Emp1.Name = "Rahul";
      Emp1.Email = "abc@abc.com"; 
      Emp1.Id = 572;

      // emp 2 specification
      Emp2.Name = "Harpreet";
      Emp2.Email = "bbc@abc.com"; 
      Emp2.Id = 957;

      Console.WriteLine( "Name : {0}", Emp1.Name);
      Console.WriteLine("Email : {0}", Emp1.Email);
      Console.WriteLine("ID :{0}", Emp1.Id);

      Console.WriteLine( "Name : {0}", Emp2.Name);
      Console.WriteLine("Email : {0}", Emp2.Email);
      Console.WriteLine("ID :{0}", Emp2.Id);       
   }
}
