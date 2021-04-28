// Ulyan Yunakh, 821704, Lab-2 LOIS

using System;
using System.Collections.Generic;
using System.Linq;

namespace FormulaLib
{
    public static class Formula
    {
        public static bool Check(string formula)
        {
            if (formula == null)
                return false;

            if (LogicConstant.Check(formula))
                return true;

            if (AtomicFormula.Check(formula))
                return true;

            if (ComplexFormula.Check(formula))
                return true;

            return false;
        }

        internal static bool Calculate(string formula)
        {
            try
            {
                return LogicConstant.Calculate(formula);
            }
            catch
            { }

            try
            {
                return ComplexFormula.Calculate(formula);
            }
            catch
            {
                throw new Exception();
            }
        }

        public static bool Compare(string firstFormula, string secondFormula)
        {
            if (!Check(firstFormula))
                return false;

            if (!Check(secondFormula))
                return false;

            List<char> firstLetterList = Alphabet.FindLetters(firstFormula);
            List<char> secondLetterList = Alphabet.FindLetters(secondFormula);

            foreach (char c in secondLetterList)
                if (firstLetterList.IndexOf(c) == -1)
                    return false;

            bool[,] matrix = new bool[(int)Math.Pow(2, firstLetterList.Count), firstLetterList.Count + 2];

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                var array = Convert.ToString(i, 2).Select(s => s.Equals('1')).ToList();
                array.Reverse();
                while (array.Count != firstLetterList.Count)
                    array.Add(false);
                array.Reverse();
                
                for (int j = 0; j < firstLetterList.Count; j++)
                    matrix[i, j] = array[j];
            }

            return true;
        }
    }
}
