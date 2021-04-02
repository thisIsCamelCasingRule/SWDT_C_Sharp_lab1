using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task5
    {
        public static String a(String row) {
            String[] guests = row.Split(";");
            String newlist = new String("");

            for (int i = 0; i < guests.Length; i++) {
                String[] current = guests[i].ToUpper().Split(":");
                guests[i] = "(" + current[1] + ", " + current[0] + ")";                   
            }

            Array.Sort(guests);

            foreach (String n in guests) {
                newlist += n;
            }
            return newlist;
        }
    }
}
