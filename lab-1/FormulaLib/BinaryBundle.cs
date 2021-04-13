using System.Collections.Generic;

// Ulyan Yunakh, 821704

namespace FormulaLib
{
    internal static class BinaryBundle
    {
        private static List<char> operation = new List<char>()
        {
            '&', // конъюнкция
            '|', // дизъюнкция
            '~', // эквиваленция
            '>'  // импликация
        };
        
        internal static bool Check(char symbol)
        {
            foreach(char item in operation)
            {
                if(symbol == item)
                    return true;
            }

            return false;
        }
    }
}