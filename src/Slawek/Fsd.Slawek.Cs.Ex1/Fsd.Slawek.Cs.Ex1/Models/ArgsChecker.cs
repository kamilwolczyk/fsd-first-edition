using System.Linq;


namespace Fsd.Slawek.Cs.Ex1.Models
{
    public static class ArgsChecker
    {
        public static int CountUpper(this string str)
        {
            return str.Count(char.IsUpper);
        }

        public static int CountLower(this string str)
        {
            return str.Count(char.IsLower);
        }

        public static int CountDigit(this string str)
        {
            return str.Count(char.IsDigit);
        }

        public static string GetUpper(this string str)
        {
            string result = null;
            str.Where(char.IsUpper).ToList().ForEach(s => result += s);
            if (string.IsNullOrEmpty(result)) return $"<There is no upper letters>";
            return result;
        }

        public static string GetLower(this string str)
        {
            string result = null;
            str.Where(char.IsLower).ToList().ForEach(s => result += s);
            if (string.IsNullOrEmpty(result)) return $"<There is no lower letters>";
            return result;
        }

        public static string GetDigit(this string str)
        {
            string result = null;
            str.Where(char.IsDigit).ToList().ForEach(s => result += s);
            if (string.IsNullOrEmpty(result)) return $"<There is no digits>";
            return result;
        }
    }
}
