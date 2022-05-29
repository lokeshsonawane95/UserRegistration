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
                Console.WriteLine("2. Enter valid Last Name");
                Console.WriteLine("3. Enter valid email");
                Console.WriteLine("4. Enter Mobile number along with country code");
                Console.WriteLine("5. Minimum 8 character password");
                Console.WriteLine("6. Password previous condition with atleast 1 upper case letter");
                Console.WriteLine("7. Password previous conditions with atleast 1 numeric number");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Validate validate1 = new Validate();
                        Console.WriteLine(validate1.Name("First"));
                        break;
                    case 2:
                        Validate validate2 = new Validate();
                        Console.WriteLine(validate2.Name("Last"));
                        break;
                    case 3:
                        Validate validate3 = new Validate();
                        Console.WriteLine("abc+100@gmail.com : " + validate3.Email("abc+100@gmail.com"));
                        Console.WriteLine("abc@gmail.com.aa.au : " + validate3.Email("abc@gmail.com.aa.au"));
                        break;
                    case 4:
                        Validate validate4 = new Validate();
                        Console.WriteLine(validate4.Mobile());
                        break;
                    case 5:
                        Validate validate5 = new Validate();
                        Console.WriteLine(validate5.Password1());
                        break;
                    case 6:
                        Validate validate6 = new Validate();
                        Console.WriteLine(validate6.Password2());
                        break;
                    case 7:
                        Validate validate7 = new Validate();
                        Console.WriteLine(validate7.Password3());
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