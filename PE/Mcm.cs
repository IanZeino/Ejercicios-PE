using System;

namespace Calculadora_de_Mcm
{
    class Mcm 
    {
        static void Main(string[] args)
        {
            int mcm = 1;
            int divisor = 2;
            int guardarUnos = 0;
            bool divisible = false;
            int[] Nums = new int[20]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

            while(guardarUnos != 20)
            { 
                guardarUnos = 0;
                for(int i = 0; i < Nums.Length; i++)
                {
                    if(Nums[i] % divisor == 0)
                    {
                        Nums[i] /= divisor;
                        divisible = true;
                    }
                    if(Nums[i] == 1)
                        guardarUnos++;
                }

                if(divisible == true)
                {
                    mcm *= divisor;
                    divisible=false;
                }
                else
                    divisor++;
            }
            Console.WriteLine(mcm);
        }
    }
}