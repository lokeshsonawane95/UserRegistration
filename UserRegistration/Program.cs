namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to User Registration Problem");
            while (true)
            {
                Console.WriteLine("\n1. Enter valid First Name");
                
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Validate validate1 = new Validate();
                        Console.WriteLine(validate1.Name("First"));
                        break;
                    
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;
                }
            }
        }
    }
}