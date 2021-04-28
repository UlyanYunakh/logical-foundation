// Ulyan Yunakh, 821704, Lab-2 LOIS

using System;

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

        internal static bool Calculate(string formula)
        {
            if (formula.Length != 1)
                throw new Exception();

            if (formula[0] == '1')
                return true;
            else if (formula[0] == '0')
                return false;
            
            throw new Exception();
        }
    }
}