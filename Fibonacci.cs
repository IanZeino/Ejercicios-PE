using System;

namespace Secuencia_de_fibonacci
{
    class SumaFiboPar 
    {
        static void Main(string[] args)
        {
            int num3 = 0;
            int num6 = 2;
            int secuencia = 0;
            int sumaSecuenciaPar = 0;
            
            while(secuencia < 4000000){
                sumaSecuenciaPar += secuencia;
                secuencia = 4 * num3 + num6;
                num6 = num3;
                num3 = secuencia;
                Console.WriteLine(sumaSecuenciaPar);
            }
        }
    }
}