﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithms
{
    class Technossus
    {
        public static string ReverseString(string input)
        {
            var source = input;
            var reversed = source.Reverse().Select(x => x.ToString()).Aggregate((x, y) => x + "." + y);
            return reversed.ToString();
        }

        public static bool IsStringPalindrome(string input)
        {
            char[] inputarray = input.ToArray();
            int i = 0, j = inputarray.Length-1;
            while(i < j)
            {
                if(inputarray[i]!=inputarray[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        public static bool PalindromeBuiltInCharArray(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return input.Equals(new string(arr));
        }

        public static bool PalindromeBuiltInEnumerable(string input)
        {
            string reversed =
                new string(Enumerable.Range(1, input.Length).Select(i => input[input.Length - i]).ToArray());
            return input.Equals(reversed);
        }
    }
}