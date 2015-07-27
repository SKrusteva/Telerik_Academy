using System.Text;

namespace ExtDelegatesLambdaLinq
{
    /* 01. Implement an extension method Substring(int index, int length) for the class StringBuilder that
     * returns new StringBuilder and has the same functionality as Substring in the class String. */

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            string input = text.ToString();
            input = input.Substring(index, length);
            return new StringBuilder(input);
        }
    }
}
