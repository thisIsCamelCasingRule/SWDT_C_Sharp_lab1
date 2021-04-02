using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Task3
    {

        public static int digital_root(int number) {
            if (number / 10 != 0) {
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
    }
}
