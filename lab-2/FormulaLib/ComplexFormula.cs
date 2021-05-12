// Ulyan Yunakh, 821704, Lab-2 LOIS

using System;

namespace FormulaLib
{
    internal static class ComplexFormula
    {
        internal static bool Check(string formula)
        {
            if (UnaryCompexFormula.Check(formula))
                return true;

            if (BinaryComplexFormula.Check(formula))
                return true;

            return false;
        }

        internal static bool Calculate(string formula)
        {
            try
            {
                return UnaryCompexFormula.Calculate(formula);
            }
            catch
            { }

            try
            {
                return BinaryComplexFormula.Calculate(formula);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}