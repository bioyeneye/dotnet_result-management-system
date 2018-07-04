using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RMS.ViewHelper
{
    public class TextHelper
    {
        /// <summary>
        /// Checks the values of a list
        /// </summary>
        /// <param name="contents">Collection to check</param>
        /// <returns></returns>
        public static bool ContainsValue(List<string> contents)
        {
            return contents.Any(string.IsNullOrWhiteSpace);
        }

        /// <summary>
        /// Validate email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmail(string email)
        {
            Regex rx = new Regex(
                @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            return rx.IsMatch(email);
        }
    }
}
