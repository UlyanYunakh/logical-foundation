// Ulyan Yunakh, 821704, Lab-1 LOIS, Variant F

namespace FormulaLib
{
    internal static class BinaryComplexFormula
    {
        private static bool FindSubFormula(string formula, out string firstFormula, out string secondFormula, out int index)
        {
            firstFormula = "";
            secondFormula = "";
            index = -1;

            if (formula[0] != '(' || formula[formula.Length - 1] != ')')
                return false;

            formula = formula.Substring(1, formula.Length - 2);

            int operationIndex = GetOperationIndex(formula);
            if (operationIndex == -1)
                return false;

            firstFormula = formula.Substring(0, operationIndex);

            int start = operationIndex + 1;
            if (formula[operationIndex] == '~')
                start--;

            secondFormula = formula.Substring(start + 1, formula.Length - start - 1);
            index = operationIndex + 1;
            return true;
        }

        private static int GetOperationIndex(string formula)
        {
            int count = 0;
            int index = -1;

            for (int i = 0; i < formula.Length; i++)
            {
                if (formula[i] == '(')
                    count++;

                if (formula[i] == ')')
                    count--;

                if (count != 0)
                    continue;

                if (formula[i] == '\\' && formula[i + 1] == '/')
                {
                    index = i;
                    break;
                }

                if (formula[i] == '/' && formula[i + 1] == '\\')
                {
                    index = i;
                    break;
                }

                if (formula[i] == '-' && formula[i + 1] == '>')
                {
                    index = i;
                    break;
                }

                if (formula[i] == '~')
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        internal static bool Check(string formula)
        {
            string firstFormula;
            string secondFormula;

            if (!FindSubFormula(formula, out firstFormula, out secondFormula, out int index))
                return false;

            bool first = Formula.Check(firstFormula);
            bool second = Formula.Check(secondFormula);

            if (first && second)
                return true;

            return false;
        }

        internal static bool CheckDNF(string formula)
        {
            string firstFormula;
            string secondFormula;
            int index;

            if (!FindSubFormula(formula, out firstFormula, out secondFormula, out index))
                return false;

            if (formula[index] == '/' && formula[index + 1] == '\\')
            {
                if (Find(firstFormula))
                    return false;
                if (Find(secondFormula))
                    return false;
            }

            bool first = Formula.CheckDNF(firstFormula);
            bool second = Formula.CheckDNF(secondFormula);

            if (first && second)
                return true;

            return false;
        }

        internal static bool Find(string formula)
        {
            for (int i = 0; i < formula.Length; i++)
            {
                if (formula[i] == '\\' && formula[i + 1] == '/')
                    return true;
            }

            return false;
        }
    }
}