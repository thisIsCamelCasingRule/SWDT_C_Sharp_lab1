using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLibrary
{
    public class StringManager
    {
        public static List<int> GetIntegersFromList(List<object> input)
        {
            if (input != null && input.Count != 0)
            {
                List<int> output = new List<int>() { };

                foreach (object n in input)
                {
                    if (n is int)
                    {
                        if ((int)n >= 0) output.Add((int)n);
                    }
                }
                return output;
            }
            return null;
        }

        public static String first_non_repeating_letter(String word)
        {
            String unrepeatedChar = "";
            word.Trim(' ');
            if (word.Length == 1) { return word; }
            for (int i = 0; i < word.Length; i++)
            {

                bool flag = true;
                for (int j = 0; j < word.Length; j++)
                {
                    if (i != j && word[i].Equals(word[j]))
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    unrepeatedChar = word[i].ToString();
                    break;
                }
            }
            return unrepeatedChar;
        }

        public static int digital_root(int number)
        {
            if (number / 10 != 0)
            {
                int iter = 0;
                int temp = number;
                while (temp % 10 != 0)
                {
                    temp /= 10;
                    iter++;
                }

                while (iter > 1)
                {
                    int sum = 0;
                    while (number % 10 != 0)
                    {
                        sum += number % 10;
                        number /= 10;
                    }
                    number = sum;
                    iter--;
                }
                return number;
            }
            return number;

        }

        public static int pairs_target(int[] array, int target)
        {
            int pairs = 0;
            if (array == null) { return 0; }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= target)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (j < i && array[i] + array[j] == target)
                        {
                            pairs++;
                        }
                    }
                }
            }
            return pairs;
        }

        public static String guestListRefactor(String row)
        {
            String newlist = "";
            Console.WriteLine(row);
            if (row.Length == 0) { return null; }
            String[] guests = row.Split(';');
            

            for (int i = 0; i < guests.Length; i++)
            {
                String[] current = guests[i].ToUpper().Trim(' ').Split(':');
                guests[i] = "(" + current[1] + ", " + current[0] + ")";
            }

            Array.Sort(guests);

            foreach (String n in guests)
            {
                newlist += n;
            }
            return newlist;
        }
    }
}
