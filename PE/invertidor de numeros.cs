using System;

namespace Invierte_numeros
{
    class soremun
    {
        static void Main(string[] args)
        {                
            int temporal = inverticion(589001);
            Console.WriteLine(temporal);
        }
        public static int inverticion (int num)
        {
            int numerillo = num;
            int nuevoNum = 0;
            string numTextual = Convert.ToString(numerillo);
            int contah = numTextual.Length - 1;
            char[] cifras = new char[numTextual.Length]; 

            foreach(char i in numTextual)
            {
                cifras[contah] = i;
                contah--;
            }
            numTextual = new string(cifras);
            nuevoNum = Convert.ToInt32(numTextual);

            return nuevoNum;
        }
    }
}