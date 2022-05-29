using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Validate
    {
        public string Name(string name)
        {
            //Regular expression or validating first name
            string REGEX_FIRSTNAME = "^[A-Z][A-Za-z]{2,}$";

            Console.Write("Enter " + name + " Name for validation : ");
            string enteredName = Console.ReadLine();

            //if enteredName matches with our expression then 2nd part will execute otherwise 3rd part
            return Regex.IsMatch(enteredName, REGEX_FIRSTNAME) ? (name + " Name is valid") : (name + " Name is invalid");
        }

        public string Email(string email)
        {
            //regular expression for validating email
            string REGEX_EMAIL = "^([A-Za-z]){3,}([_.+-]{1}[0-9A-Za-z]{1,}){0,}@[a-z0-9]+[.](com|net){0,1}([.]((com)|([a-z]{2}){0,1})){0,1}$";

            //Console.Write("Enter Email Name for validation : ");
            //string enteredEmail = Console.ReadLine();
            return Regex.IsMatch(email, REGEX_EMAIL) ? "Email is valid" : "Email is invalid";
        }
    }
}
