using System.Text;

namespace UrlShortener.Api.Core.Tests
{
    public static class Base62Extensions
    {
        private const string Base62Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public static string EncodeToBase62(this int number)
        {
            var result = new StringBuilder();
            while (number > 0)
            {
                result.Insert(0, Base62Chars[number % 62]);
                number /= 62;
            }
            return result.ToString();
        }
    }
}