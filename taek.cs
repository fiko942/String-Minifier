using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Minifier
{
    public static class taek
    {
        public static String ReduceWhitespace(this String value)
        {
            var newString = new StringBuilder();
            bool previousIsWhitespace = false;
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsWhiteSpace(value[i]))
                {
                    if (previousIsWhitespace)
                    {
                        continue;
                    }

                    previousIsWhitespace = true;
                }
                else
                {
                    previousIsWhitespace = false;
                }

                newString.Append(value[i]);
            }

            return newString.ToString();
        }
    }
}
