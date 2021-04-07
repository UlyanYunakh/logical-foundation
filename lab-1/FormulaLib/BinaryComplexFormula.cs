namespace FormulaLib
{
    internal static class BinaryComplexFormula
    {
        internal static bool Check(string formula)
        {
            if (formula[0] != '(' || formula[formula.Length - 1] != ')')
                return false;

            formula = formula.Substring(1, formula.Length - 2);

            int operationIndex = GetOperationIndex(formula);
            if (operationIndex == -1)
                return false;

            string firstFormula = formula.Substring(0, operationIndex);
            string secondFormula = formula.Substring(operationIndex + 1, formula.Length - operationIndex - 1);

            bool first = Formula.Check(firstFormula);
            bool second = Formula.Check(secondFormula);

            if (first && second)
                return true;

            return false;
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

                if (BinaryBundle.Check(formula[i]))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}