using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public static bool URLSplit(string line)
        {
            bool result = false;
            string[] str;
            try
            {
                str = line.Split(',');
                if (str[0].EndsWith(str[1]))
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

        /*Function to solve the third problem - Need to work on the solution. Messed up*/
        public static bool FormattedString(string line)
        {
            bool result = false;
            string[] str;
            try
            {
                str = line.Split(',');
                if (str[0].EndsWith(str[1]))
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
    }
}
