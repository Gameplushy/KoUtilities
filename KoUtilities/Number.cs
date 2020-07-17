using System;
using System.Collections.Generic;
using System.Text;

namespace KoUtilities
{
    public static class Number
    {
        public static bool IsInInclusiveRange(this int number, int min, int max)
        {
            return (number >= min && number <= max);
        }

        public static bool IsNotInInclusiveRange(this int number, int min, int max)
        {
            return !(number >= min && number <= max);
        }
    }
}
