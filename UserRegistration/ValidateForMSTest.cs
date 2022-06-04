using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class ValidateForMSTest
    {
        string REGEX_NAME = "^[A-Z][A-Za-z]{2,}$";

        string REGEX_EMAIL = "^([A-Za-z]){3,}(([_.+-]?)([0-9A-Za-z]{1,}))*@[a-z0-9]+[.](com|net){0,1}([.]((com)|([a-z]{2}){0,1})){0,1}$";

        string REGEX_CELLNO = "^[1-9]{1,3}[ ][6-9]{1}[0-9]{9}$";

        string REGEX_PASS = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";

        public string Name(string name)
        {
            Regex regex = new Regex(REGEX_NAME);

            bool result = regex.IsMatch(name);
            if (result)
            {
                return name;
            }
            else
            {
                return default;
            }
        }

        public string Email(string email)
        {
            Regex regex = new Regex(REGEX_EMAIL);

            bool result = regex.IsMatch(email);
            if (result)
            {
                return email;
            }
            else
            {
                return default;
            }
        }

        public string Mobile(string cell)
        {
            Regex regex = new Regex(REGEX_CELLNO);

            bool result = regex.IsMatch(cell);
            if (result)
            {
                return cell;
            }
            else
            {
                return default;
            }
        }

        public string Password(string pass)
        {
            Regex regex = new Regex(REGEX_PASS);

            bool result = regex.IsMatch(pass);
            if (result)
            {
                return pass;
            }
            else
            {
                return default;
            }
        }
    }
}
