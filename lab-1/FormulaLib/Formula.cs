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
    }
}
