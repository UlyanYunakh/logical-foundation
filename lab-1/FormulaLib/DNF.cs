// Ulyan Yunakh, 821704

namespace FormulaLib
{
    public static class DNF
    {
        public static bool Check(string formula)
        {
            if(!Formula.PreCheckDNF(formula))
                return false;

            if(!Formula.CheckDNF(formula))
                return false;

            return true;
        }
    }
}