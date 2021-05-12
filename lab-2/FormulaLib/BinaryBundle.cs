// Ulyan Yunakh, 821704, Lab-2 LOIS

namespace FormulaLib
{
    internal static class BinaryBundle
    {
        internal static string Disjunction { get; } = "\\/";
        internal static string Conjunction { get; } = "/\\";
        internal static string Equivalence { get; } = "~";
        internal static string Implication { get; } = "->";

        internal static int GetOperationIndex(string formula)
        {
            int count = 0;
            int index = -1;

            for (int i = 0; i < formula.Length; i++)
            {
                if (formula[i] == '(')
                    count++;

                if (formula[i] == ')')
                    count--;

                if (count != 0)
                    continue;

                if (formula[i] == '\\' && formula[i + 1] == '/') // дизъюнкция
                {
                    index = i;
                    break;
                }

                if (formula[i] == '/' && formula[i + 1] == '\\') // конъюнкция
                {
                    index = i;
                    break;
                }

                if (formula[i] == '-' && formula[i + 1] == '>') // импликация
                {
                    index = i;
                    break;
                }

                if (formula[i] == '~') // эквиваленция
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}