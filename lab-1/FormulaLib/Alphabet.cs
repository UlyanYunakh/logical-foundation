using System.Collections.Generic;

// Ulyan Yunakh, 821704, Lab-1 LOIS, Variant F

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
    }
}