using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TrabalhoDM.Extensions
{
    public static class CaptalizeExtension
    {
        public static string ToCaptalize(this string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }
    }
}
