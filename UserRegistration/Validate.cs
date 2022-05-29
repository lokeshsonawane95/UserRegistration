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
    }
}
