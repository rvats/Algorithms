using System;
using System.Linq;
using System.Threading;

namespace Algorithms
{
    public delegate void IsStringPalindromeCallBack(bool result);

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
            int i = 0, j = inputarray.Length - 1;
            while (i < j)
            {
                if (inputarray[i] != inputarray[j])
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

        public static bool IsNumberPrime(int number)
        {
            // Test whether the parameter is a prime number.
            if ((number % 2) == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return number != 1;
        }

        public static void PalindromeStringThread(object input)
        {
            IsStringPalindromeCallBack result = new IsStringPalindromeCallBack(IsStringPalindrome);
            if (input != null)
            {
                string test = input.ToString();
                char[] inputarray = test.ToArray();
                int i = 0, j = inputarray.Length - 1;
                while (i < j)
                {
                    if (inputarray[i] != inputarray[j])
                    {
                        result(false);
                        return;
                    }
                    i++;
                    j--;
                }
            }
            result(true);
        }

        public static void IsStringPalindrome(bool output)
        {
            if (output)
                Console.WriteLine("String is Palindrome");
        }

        public static void IsStringPalindromeUsingThreading(string input)
        {

            IsStringPalindromeCallBack result = new IsStringPalindromeCallBack(IsStringPalindrome);
            Thread comparechar = new Thread(new ParameterizedThreadStart(PalindromeStringThread));
            comparechar.Start(input);

        }
    }
}
//At the end of each file there are sample use cases which can be entered into the main program to run the code.
/*
            string choice = "Y";
            while (choice.Equals("y")|| choice.Equals("Y"))
            {
                //string reverse;
                //reverse = Technossus.ReverseString(line);
                //Console.WriteLine(reverse);

                //Technossus.IsStringPalindromeUsingThreading(line);
                //if (Technossus.IsStringPalindrome(line))
                //{
                //    Console.WriteLine(line + " is a palindrome.");
                //}
                //else
                //{
                //    Console.WriteLine(line + " is not a palindrome.");
                //}

                //int number = 0;
                //if(int.TryParse(line, out number))
                //{
                //    if(Technossus.IsNumberPrime(number))
                //    {
                //        Console.WriteLine("{0} is Prime",number);
                //    }
                //    else
                //    {
                //        Console.WriteLine("{0} is Not Prime", number);
                //    }
                //}
                Console.Write("Continue (Y/N): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            } 
*/
