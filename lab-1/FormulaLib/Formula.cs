using System;

namespace FormulaLib
{
    public static class Formula
    {
        public static bool Check(string formula)
        {
            if (LogicConstant.Check(formula))
                return true;

            if (AtomicFormula.Check(formula))
                return true;

            if (ComplexFormula.Check(formula))
                return true;

            return false;
        }

        internal static bool PreCheckDNF(string formula)
        {
            if (formula.IndexOf('0') != -1 || formula.IndexOf('1') != -1)
                return false;

            if (formula.IndexOf('~') != -1 || formula.IndexOf('>') != -1)
                return false;

            if (formula.IndexOf('|') == -1)
                return false;

            return true;
        }

        internal static bool CheckDNF(string formula)
        {
            if (AtomicFormula.Check(formula))
                return true;

            if (ComplexFormula.CheckDNF(formula))
                return true;

            return false;
        }
    }
}
