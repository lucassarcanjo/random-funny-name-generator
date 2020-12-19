using System.Globalization;

namespace Random.API.Extensions
{
   public static class StringExtensions
   {
        public static string ToTitleCase(this string title)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
        }
   }
}