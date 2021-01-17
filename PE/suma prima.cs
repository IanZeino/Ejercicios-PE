using System;

namespace sumate_los_primos
{
    class suma
    {
        static void Main(string[] args){
            int n = 3;
            long sumaPrima = 2;
            bool compruebaPrim = true;
            int divisores = 2;
            
            while(n < 2000_000)
            {
                while(divisores*divisores <= n) 
                {
                    if(n%divisores == 0)
                    {
                        compruebaPrim = false;
                        break;
                    }
                    divisores++;
                }
                if(compruebaPrim)
                {
                    sumaPrima+=n;
                }
                compruebaPrim = true;
                divisores=2;
                n++;
            }
            Console.WriteLine(sumaPrima);
        }
    }
}





