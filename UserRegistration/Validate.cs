using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Validate
    {
        public Func<string, string> Name = (name) =>
        {
            //Regular expression or validating name
            string REGEX_FIRSTNAME = "^[A-Z][A-Za-z]{2,}$";

            Console.Write("Enter " + name + " Name for validation : ");
            string enteredName = Console.ReadLine();

            try
            {
                if (enteredName.Equals(""))
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.EMPTY_STRING, "Name should not be empty");
                }
                if (enteredName.Equals(null))
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.NULL_STRING, "Name should not be null");
                }
                if (Regex.IsMatch(enteredName, REGEX_FIRSTNAME))
                {
                    Console.WriteLine(name + " Name is valid");
                    return enteredName;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_STRING, "Name should be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        };

        public Func<string, string> Email = (email) =>
        {
            //regular expression for validating email
            string REGEX_EMAIL = "^([A-Za-z]){3,}(([_.+-]?)([0-9A-Za-z]{1,}))*@[a-z0-9]+[.](com|net){0,1}([.]((com)|([a-z]{2}){0,1})){0,1}$";

            //Console.Write("Enter Email Name for validation : ");
            //string enteredEmail = Console.ReadLine();

            try
            {
                if (email.Equals(""))
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.EMPTY_STRING, "Email should not be empty");
                }
                if (email.Equals(null))
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.NULL_STRING, "Email should not be ull");
                }
                if (Regex.IsMatch(email, REGEX_EMAIL))
                {
                    Console.WriteLine("Email is valid");
                    return email;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_STRING, "Email should be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        };

        public Func<string, string> Mobile = (enteredMobileNumber) =>
        {
            //Regular expression for checking mobile number, all mobile numbers starts with 6, 7, 8 or 9
            string REGEX_CELLNO = "^[1-9]{1,3}[ ][6-9]{1}[0-9]{9}$";

            try
            {
                if (enteredMobileNumber.Equals(""))
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.EMPTY_STRING, "Mobile number not be empty");
                }
                if (enteredMobileNumber.Equals(null))
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.NULL_STRING, "Mobile number not be ull");
                }
                if (Regex.IsMatch(enteredMobileNumber, REGEX_CELLNO))
                {
                    Console.WriteLine("Mobile number is valid");
                    return enteredMobileNumber;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_STRING, "Mobile number be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        };

        public string Password1()
        {
            //Regular expression below will match any character except space i.e. " "
            string REGEX_PASS = "^.{8,}$";

            Console.Write("Enter password for validation : ");
            string enteredPassword = Console.ReadLine();
            return Regex.IsMatch(enteredPassword, REGEX_PASS) ? "Password is valid" : "Password is invalid";
        }

        public string Password2()
        {
            //Regular expression to match previous condition + atleast one Upper Case
            string REGEX_PASS = "^(?=.*[A-Z]).{8,}$";

            Console.Write("Enter password for validation : ");
            string enteredPassword = Console.ReadLine();
            return Regex.IsMatch(enteredPassword, REGEX_PASS) ? "Password is valid" : "Password is invalid";
        }

        public string Password3()
        {
            //Regular expression below will match all previous conditions + atleast one numeric value
            string REGEX_PASS = "^(?=.*[A-Z0-9]).{8,}$";

            Console.Write("Enter password for validation : ");
            string enteredPassword = Console.ReadLine();
            return Regex.IsMatch(enteredPassword, REGEX_PASS) ? "Password is valid" : "Password is invalid";
        }

        public Func<string, string> Password4 = (enteredPassword) =>
        {
            //Regular expression below will match previous conditions + exactly one special character
            string REGEX_PASS = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";

            try
            {
                if (enteredPassword.Equals(""))
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.EMPTY_STRING, "Password not be empty");
                }
                if (enteredPassword.Equals(null))
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.NULL_STRING, "Password not be ull");
                }
                if (Regex.IsMatch(enteredPassword, REGEX_PASS))
                {
                    Console.WriteLine("Password is valid");
                    return enteredPassword;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_STRING, "Password be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        };

        //Method to test each Valid and Invalid email provided separately for testing
        public void Test()
        {
            Validate validate = new Validate();
            Console.WriteLine("A. Valid Emails");
            string[] validEmails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            for (int i = 0; i < validEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + validEmails[i] + " : " + validate.Email(validEmails[i]));
            }
            Console.WriteLine("\nB. Invalid Emails");
            string[] invalidEmails = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            for (int i = 0; i < invalidEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + invalidEmails[i] + " : " + validate.Email(invalidEmails[i]));
            }
        }
    }
}
