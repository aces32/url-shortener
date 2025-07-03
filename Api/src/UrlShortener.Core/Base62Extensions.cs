using System.Text;

namespace UrlShortener.Api.Core
{
    public static class Base62Extensions
    {
        private const string Base62Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public static string EncodeToBase62(this long number)
        {
            var result = new StringBuilder();

            if (number == 0) return Base62Chars[0].ToString();
            while (number > 0)
            {
                result.Insert(0, Base62Chars[(int)(number % 62)]);
                number /= 62;
            }
            return result.ToString();
        }
    }
}