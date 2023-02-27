
class program { 
  public static void Main()
    {
        string FirstName, MiddleName, LastName;

        Console.WriteLine("Please Enter First Name");
        FirstName = Console.ReadLine();

        Console.WriteLine("Please Enter Middle Name");
        MiddleName = Console.ReadLine();

        Console.WriteLine("Please Enter Last Name");
        LastName = Console.ReadLine();

        string FullName = FirstName + " " + MiddleName + " " + LastName;

        Console.WriteLine(FullName);
        Console.WriteLine("----------------------------------------------------------------");

        Program1 program1= new Program1();
        program1.Pattern();
        Program2 program2= new Program2();
        program2.Pattern(); 
      
    }
}
 class Program1
{
    public void Pattern()
    {
        string FirstName, MiddleName, LastName;

        Console.WriteLine("Please Enter First Name");
        FirstName = Console.ReadLine();

        Console.WriteLine("Please Enter Middle Name");
        MiddleName = Console.ReadLine();

        Console.WriteLine("Please Enter Last Name");
        LastName = Console.ReadLine();

        string FullName = FirstName + " " + MiddleName + " " + LastName;

        Console.WriteLine(FullName);
        Console.WriteLine("----------------------------------------------------------------");
    }
    
    
}

class Program2
{
    public void Pattern()
    {
        string FirstName, MiddleName, LastName;

        Console.WriteLine("Please Enter First Name");
        FirstName = Console.ReadLine();

        Console.WriteLine("Please Enter Middle Name");
        MiddleName = Console.ReadLine();

        Console.WriteLine("Please Enter Last Name");
        LastName = Console.ReadLine();

        string FullName = FirstName + " " + MiddleName + " " + LastName;

        Console.WriteLine(FullName);
        Console.WriteLine("----------------------------------------------------------------");
    }


}