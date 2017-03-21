using System;

namespace Fsd.Michal.Cs.Ex1
{
    class WordAnalyzer
    {
        public static int CountDigits(string word)
        {
            int count = 0;

            foreach (Char c in word)
                if (char.IsDigit(c))
                    count++;

            return count;
        }

        public static int CountLowerLetter(string word)
        {
            int count = 0;

            foreach (Char c in word)
                if (char.IsLower(c))
                    count++;

            return count;
        }

        public static int CountUpperLetters(string word)
        {
            int count = 0;

            foreach (Char c in word)
                if (char.IsUpper(c))
                    count++;

            return count;
        }
    }
}
