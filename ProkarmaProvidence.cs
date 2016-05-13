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
            string protocol = "", domain = "", query = "";
            string output = "";
            try
            {
                if(line.Contains("?"))
                {
                    query = line.Split('?')[1];
                }
                if(line.Contains("://"))
                {
                    protocol = Regex.Split(line, "://")[0];
                    domain = Regex.Split(line, "://")[1];
                    if(domain.Contains("/"))
                    {
                        domain = domain.Split('/')[0];
                    }
                }               
                
                if (!String.IsNullOrEmpty(protocol))
                {
                    output = protocol;
                }
                if (!String.IsNullOrEmpty(domain))
                {
                    if (!String.IsNullOrEmpty(output))
                    {
                        output = output + "," + domain;
                    }
                    else
                    {
                        output = domain;
                    }
                }
                if (!String.IsNullOrEmpty(query))
                {
                    if(!String.IsNullOrEmpty(output))
                    {
                        output = output + "," + query;
                    }
                    else
                    {
                        output = domain;
                    }
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
            var stack = new Stack<char>();
            // dictionary of matching starting and ending pairs
            var allowedChars = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' }, { '{', '}' } };

            var wellFormated = true;
            foreach (var chr in line)
            {
                if (allowedChars.ContainsKey(chr))
                {
                    // if starting char then push on stack
                    stack.Push(chr);
                }
                // ContainsValue is linear but with a small number is faster than creating another object
                else if (allowedChars.ContainsValue(chr))
                {
                    // make sure something to pop if not then know it's not well formated
                    wellFormated = stack.Any();
                    if (wellFormated)
                    {
                        // hit ending char grab previous starting char
                        var startingChar = stack.Pop();
                        // check it is in the dictionary
                        wellFormated = allowedChars.Contains(new KeyValuePair<char, char>(startingChar, chr));
                    }
                    // if not wellformated exit loop no need to continue
                    if (!wellFormated)
                    {
                        break;
                    }
                }
            }
            return wellFormated;
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