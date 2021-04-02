using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        public class Task1{
        public static List<int> GetIntegersFromList(List<object> input)
        {
            if (input != null)
            {
                List<int> output = new List<int>() {};
             
                foreach (object n in input)
                {
                    if (n is int) {
                        if ((int)n >= 0) output.Add((int)n);
                    }
                }
                return output;
            }
            return null;
        }
    }
}
