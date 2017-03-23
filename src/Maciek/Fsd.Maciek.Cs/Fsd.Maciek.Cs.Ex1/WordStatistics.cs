namespace Fsd.Maciek.Cs.Ex1
{
    static internal class WordStatistics
    {
        internal static int CalculateUpperCasesInWord(string word)
        {
            int upperCaseCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                    upperCaseCount++;
            }

            return upperCaseCount;
        }

        internal static int CalculateLowerCasesInWord(string word)
        {
            int lowerCaseCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                    lowerCaseCount++;
            }

            return lowerCaseCount;
        }

        internal static int CalculateDigitsInWord(string word)
        {
            int digitsCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                    digitsCount++;
            }

            return digitsCount;
        }
    }
}
