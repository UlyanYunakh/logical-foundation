// Ulyan Yunakh, 821704, Lab-1 LOIS, Variant F

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

        internal static bool CheckDisjunction(string formula)
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

            if (formula[indexStart] == '-' && formula[indexStart + 1] == '>' || formula[indexStart] == '~')
                return false;

            if (formula[indexStart] == '/' && formula[indexStart + 1] == '\\')
            {
                if (firstFormula.IndexOf(BinaryBundle.Disjunction) != -1)
                    return false;
                if (secondFormula.IndexOf(BinaryBundle.Disjunction) != -1)
                    return false;
            }

            bool first = DNF.CheckDNF(firstFormula);
            bool second = DNF.CheckDNF(secondFormula);

            if (first && second)
                return true;

            return false;
        }
    }
}