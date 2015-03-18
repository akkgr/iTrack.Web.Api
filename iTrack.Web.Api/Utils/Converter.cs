using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iTrack.Web.Api.Utils
{
    public static class Converter
    {
        public static long[] StringToLongArray(string input)
        {
            string[] stringArray = input.Split(',');
            long[] longArray = new long[stringArray.Length];
            for (int index = 0; index < stringArray.Length; index++)
            {
                longArray[index] = Convert.ToInt64(stringArray[index]);
            }
            return longArray;
        }
    }
}