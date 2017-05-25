using System;
using System.Text;


namespace TrabalhoDM.Extensions
{
    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            return new StringBuilder(builder.ToString(index, length));
        }
    }
}
