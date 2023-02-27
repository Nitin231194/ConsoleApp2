
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

    string FullName = FirstName +" "+ MiddleName +" "+ LastName ;

    Console.WriteLine(FullName);
}
}