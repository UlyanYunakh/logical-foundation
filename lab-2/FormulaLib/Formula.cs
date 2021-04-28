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

        public static bool Compare(string firstFormula, string secondFormula)
        {
            if (!Check(firstFormula))
                return false;

            if (!Check(secondFormula))
                return false;

            List<char> firstLetterList = Alphabet.FindLetters(firstFormula);
            List<char> secondLetterList = Alphabet.FindLetters(secondFormula);

            if (!firstLetterList.SequenceEqual(secondLetterList))
                return false;

            return true;
        }
    }
}
