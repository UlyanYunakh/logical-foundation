// Ulyan Yunakh, 821704, Lab-1 LOIS, Variant F

namespace FormulaLib
{
    internal static class AtomicFormula
    {
        internal static bool Check(string formula)
        {
            if (formula.Length != 1)
                return false;

            foreach (char letter in Alphabet.LatinLetter)
            {
                if (formula[0] == letter)
                    return true;
            }

            return false;
        }
    }
}