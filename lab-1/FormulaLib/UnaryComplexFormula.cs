namespace FormulaLib
{
    internal static class UnaryCompexFormula
    {
        private static bool FindSubFormula(ref string formula)
        {
            if (formula[0] != '(' || formula[formula.Length - 1] != ')')
                return false;

            formula = formula.Substring(1, formula.Length - 2);

            if (formula[0] != '!')
                return false;

            formula = formula.Substring(1);

            return true;
        }

        public static bool Check(string formula)
        {
            if (!FindSubFormula(ref formula))
                return false;

            if (Formula.Check(formula))
                return true;

            return false;
        }

        public static bool CheckDNF(string formula)
        {
            if (!FindSubFormula(ref formula))
                return false;

            if (Formula.CheckDNF(formula))
                return true;

            return false;
        }
    }
}