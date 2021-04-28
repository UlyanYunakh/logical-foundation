// Ulyan Yunakh, 821704, Lab-2 LOIS

namespace FormulaLib
{
    internal static class BinaryComplexFormula
    {
        internal static bool Check(string formula)
        {
            if (formula[0] != '(' || formula[formula.Length - 1] != ')')
                return false;

            formula = formula.Substring(1, formula.Length - 2);

            int indexStart = BinaryBundle.GetOperationIndex(formula);

            if (indexStart == -1)
                return false;

            string firstFormula = formula.Substring(0, indexStart);

            int indexEnd = indexStart + 1;
            if (formula[indexStart] == '~')
                indexEnd--;

            string secondFormula = formula.Substring(indexEnd + 1, formula.Length - indexEnd - 1);

            bool first = Formula.Check(firstFormula);
            bool second = Formula.Check(secondFormula);

            if (first && second)
                return true;

            return false;
        }
    }
}