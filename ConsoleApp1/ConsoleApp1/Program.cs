using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //List<int> result = ListFilter.GetIntegersFromList(new List<object>() { 1, 2, 'a', 'b' });
            List<int> result = Task1.GetIntegersFromList(new List<object>() { 1, 2, 'a', 'b', 0, 15 });
            //List<int> result = ListFilter.GetIntegersFromList(new List<object>() { (1, 2, 'a', 'b', 'aasf', '1', '123', 231});
            /*foreach (int k in result) {
                Console.WriteLine(k);
            }*/
            //Console.WriteLine(Task2.first_non_repeating_letter("sTreSS"));
            //Console.WriteLine(Task3.digital_root(34232));
            //int[] inputArrayTask4 = { 1, 3, 6, 2, 2, 0, 4, 5 };
            //Console.WriteLine(Task4.pairs_target(inputArrayTask4, 5));
            Console.Write(Task5.a("Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill"));

        }
    }
}
