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
    }
}
