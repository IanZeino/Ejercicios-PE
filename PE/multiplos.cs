using System;

namespace sumate_las_chivas
{
    class suma_multiplos_xd
    {
        static void Main(string[] args)
        {
            Console.WriteLine(suma_de_multiplos(3, 5));
        }
        static int suma_de_multiplos (int num, int num2)
        {
            int numIgual = minimoMulti(num, num2);
            int sumMultiIguales = 0;
            int sumMultiplos1 = 0;
            int sumMultiplos2 = 0;

            for(int i = num ; i < 1000; i+=num)
                sumMultiplos1 += i;

            for(int i = num2; i < 1000; i+=num2)
                sumMultiplos2 += i;

            for (int i = numIgual; i < 1000; i+=numIgual)
                sumMultiIguales += i;

            int sumTotal = sumMultiplos1 + sumMultiplos2 - sumMultiIguales;

            return sumTotal;
        }
        static int minimoMulti (int num, int num2)
        {
            int mcm = 1;
            int divisor = 2;
            int guardarUnos = 0;
            bool divisible = false;
            int[] Nums = new int[2]{num, num2};

            while(guardarUnos != 2)
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
            return mcm;
        }
    }
}
