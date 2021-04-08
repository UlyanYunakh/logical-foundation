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

        internal static bool CheckDNF(string formula)
        {
            if (UnaryCompexFormula.CheckDNF(formula))
                return true;

            if (BinaryComplexFormula.CheckDNF(formula))
                return true;
                
            return false;
        }
    }
}