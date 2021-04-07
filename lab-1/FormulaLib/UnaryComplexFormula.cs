namespace FormulaLib
{
    internal static class UnaryCompexFormula
    {
        public static bool Check(string formula)
        {
            if (formula[0] != '(' || formula[formula.Length - 1] != ')')
                return false;

            formula = formula.Substring(1, formula.Length - 2);

            if (formula[0] != '!')
                return false;

            formula = formula.Substring(1);

            if (Formula.Check(formula))
                return true;

            return false;
        }
    }
}