using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace MyFio
{
    public static class FioCheck
    {
        public static bool ValidName(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            return Regex.IsMatch(text, "^[A - Za - zA]");
        }

        public static bool ValidAge(string age)
        {
            return Regex.IsMatch(age, @"^\d+$");
        }

        public static bool ValidPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone)) return false;
            return Regex.IsMatch(phone, @" ^\+380\d{9}$");
        }

        public static bool ValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }
    }
}
