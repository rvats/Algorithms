using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithms
{
    class ProkarmaProvidence
    {
        public static long Square (string line)
        {
            int number = 0;
            long square = 0;
            try
            {
                if (int.TryParse(line, out number))
                {
                    square = number * number;
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Integer");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return square;
        }

        /*Function to solve the first problem*/
        public static bool SubStringTest(string line)
        {
            bool result = false;
            string[] str;
            try
            {
                str = line.Split(',');
                if(str[0].EndsWith(str[1]))
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        /*Function to solve the second problem - Need to work on the solution. Attempted and solve the problem*/
        public static string URLSplit(string line)
        {
            string protocol, domain, query = "";
            string output = "";
            try
            {
                query = line.Split('?')[1];
                protocol = Regex.Split(line, "://")[0];
                domain = Regex.Split(line, "://")[1];
                domain = domain.Split('/')[0];
                output = protocol + "," + domain;
                if (!String.IsNullOrEmpty(query))
                {
                    output = output + "," + query;
                }
            }
            catch (Exception ex)
            {
                output = ex.ToString();
            }
            return output;
        }

        /*Function to solve the third problem - Need to work on the solution. Messed up*/
        public static bool FormattedString(string line)
        {
            bool result = false;
            try
            {
                var allowedChars = new HashSet<char>(new[] { '(', '[', '{', ')', ']', '}' });
                var stack = new Stack<char>(line.Where(c => allowedChars.Contains(c)));
                
                var reverseStack = stack.Reverse();
                var sequencedBalanced = reverseStack.SequenceEqual(stack, BalancedParanthesisComparer.Instance);
                result = sequencedBalanced;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }
}

public sealed class BalancedParanthesisComparer : EqualityComparer<char>
{
    private static readonly BalancedParanthesisComparer _instance = new BalancedParanthesisComparer();

    private BalancedParanthesisComparer() { }

    public static BalancedParanthesisComparer Instance { get { return _instance; } }

    public override bool Equals(char x, char y)
    {
        if ((x == '(' && y == ')') || (y == '(' && x == ')'))
            return true;
        if ((x == '[' && y == ']') || (y == '[' && x == ']'))
            return true;
        if (x == '{' && y == '}' || (y == '{' && x == '}'))
            return true;

        return false;
    }

    public override int GetHashCode(char obj)
    {
        throw new NotImplementedException();
    }
}