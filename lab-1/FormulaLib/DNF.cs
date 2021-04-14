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

            if (!Formula.PreCheckDNF(formula))
                return false;

            if (!Formula.CheckDNF(formula))
                return false;

            return true;
        }
    }
}