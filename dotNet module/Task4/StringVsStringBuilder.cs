using System.Text;

namespace Task4
{
    public class StringVsStringBuilder
    {
        public static string StringConcatenation()
        {
            var str = string.Empty;
            for (int i = 0; i < 50000; i++)
            {
                str += i.ToString() + ", ";
            }
            return str;
        }

        public static void GetSubstringFromString(string str)
        {
            for (int i = 0; i < 50000; i++)
            {
                str = str.Substring(str.Length / 2);
            }
        }

        public static StringBuilder StringBuilderConcatenation()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < 50000; i++)
            {
                builder.Append(i);
                builder.Append(", ");
            }
            return builder;
        }

        public static void GetSubstringFromStringBuilder(StringBuilder builder)
        {
            for (int i = 0; i < 50000; i++)
            {
                var str = builder.ToString();
                str.Substring(str.Length / 2);
            }
        }
    }
}
