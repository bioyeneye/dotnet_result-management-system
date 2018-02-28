using System.Collections.Generic;
using System.Linq;

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
    }
}
