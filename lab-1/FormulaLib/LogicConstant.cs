// Ulyan Yunakh, 821704, Lab-1 LOIS, Variant F

namespace FormulaLib
{
    internal class LogicConstant
    {
        internal static bool Check(string formula)
        {
            if (formula.Length != 1)
                return false;

            if (formula[0] != '0' && formula[0] != '1')
                return false;

            return true;
        }
    }
}