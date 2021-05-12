using System.Collections.Generic;

// Ulyan Yunakh, 821704, Lab-2 LOIS

namespace FormulaLib
{
    internal static class Alphabet
    {
        internal static List<char> LatinLetter { get; private set; }

        static Alphabet()
        {
            LatinLetter = new List<char>()
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
                'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
        }

        internal static List<char> FindLetters(string formula)
        {
            List<char> letters = new List<char>();

            foreach (char c in LatinLetter)
                if (formula.IndexOf(c) != -1)
                    letters.Add(c);

            return letters;
        }
    }
}