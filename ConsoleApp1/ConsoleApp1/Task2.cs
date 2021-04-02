using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task2
    {
        public static String first_non_repeating_letter(String word){
            String unrepeatedChar = "";
            word.Trim();
            for (int i = 0; i < word.Length;i++) {
                bool flag = true;
                for (int j =0; j < word.Length;j++) {
                    if (i != j && word[i].Equals(word[j])) {
                        flag = false;
                    }                     
                }
                if (flag) {
                    unrepeatedChar = word[i].ToString();
                    break;
                }
            }
            return unrepeatedChar;
        }
    }
}
