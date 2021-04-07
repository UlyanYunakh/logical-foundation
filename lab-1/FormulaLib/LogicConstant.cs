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