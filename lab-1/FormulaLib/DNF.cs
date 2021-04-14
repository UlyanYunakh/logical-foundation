// Ulyan Yunakh, 821704, Lab-1 LOIS, Variant F

namespace FormulaLib
{
    public static class DNF
    {
        public static bool Check(string formula)
        {
            if (formula == null)
                return false;

            if (!Formula.Check(formula))
                return false;

            if (!CheckDNF(formula))
                return false;

            return true;
        }

        internal static bool CheckDNF(string formula)
        {
            if (LogicConstant.Check(formula))
                return false;

            if (AtomicFormula.Check(formula))
                return true;

            if (ComplexFormula.CheckDNF(formula))
                return true;

            return false;
        }
    }
}