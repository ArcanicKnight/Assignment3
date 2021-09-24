using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri uri)
        {
            return uri.ToString().StartsWith("https");
        }

        public static int WordCount(this string str)
        {
            return Regex.Matches(str, @"[a-zA-Z]+").Count;
        }
    }
}