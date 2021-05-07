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
            List<char> firstLetterList = Alphabet.FindLetters(firstFormula);
            List<char> secondLetterList = Alphabet.FindLetters(secondFormula);

            var letterList = firstLetterList.Union(secondLetterList).ToList();

            int num = (int)Math.Pow(2, letterList.Count);

            for (int i = 0; i < num; i++)
            {
                var boolList = Convert.ToString(i, 2).ToList();

                boolList.Reverse();
                int count = Math.Abs(letterList.Count - boolList.Count);
                for (int j = 0; j < count; j++)
                    boolList.Add('0');
                boolList.Reverse();

                string firstLogicalFormula = ToLogical(firstFormula, boolList, letterList);
                string secondLogicalFormula = ToLogical(secondFormula, boolList, letterList);

                if (Calculate(firstLogicalFormula))
                    if (!Calculate(secondLogicalFormula))
                        return false;
            }

            return true;
        }

        public static string ToLogical(string formula, List<char> boolList, List<char> charList)
        {
            foreach (char c in charList)
                formula = formula.Replace(c, boolList[charList.IndexOf(c)]);
            return formula;
        }
    }
}
