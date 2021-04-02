using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task4
    {

        public static int pairs_target(int[] array, int target) {
            int pairs = 0;
            for (int i = 0;i < array.Length; i++) {
                if (array[i] <= target) {
                    for (int j = 0; j < array.Length; j++) {
                        if (j < i && array[i] + array[j] == target) {
                            pairs++;
                        }
                    }
                }
            }
            return pairs;
        }
    }
}
