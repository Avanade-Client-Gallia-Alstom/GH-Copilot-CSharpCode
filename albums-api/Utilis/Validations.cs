using System.Text.RegularExpressions;

namespace albums_api.Utilis
{
    public class Validations
    {
       //Create a regex function to validate IPV6 address, phone number and email address
       public static bool ValidateIPv6Address(string ipv6)
        {
            string pattern = @"^([0-9a-fA-F]{1,4}:){7}([0-9a-fA-F]{1,4})$";
            return Regex.IsMatch(ipv6, pattern);
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        public static bool ValidateEmailAddress(string emailAddress)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(emailAddress, pattern);
        }
    }
}
