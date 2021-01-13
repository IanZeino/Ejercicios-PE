using System;

namespace sumate_las_chivas
{
    class suma_4
    {
        static void Main(string[] args){
            string numero = "134789997314810";
            int indice = 0;
            string trozo;
            int textonum = 0;
            int suma = 0;
            int valorfin = 0;
            string digitos = "";

            while(indice < 12){
                trozo= numero.Substring(indice,4);
                textonum = int.Parse(trozo);
                indice++;
                while(textonum > 0){
                    suma = suma + textonum % 10;
                    textonum = textonum/10;
                }
                if (valorfin < suma){
                    valorfin = suma;
                    digitos = trozo;
                }
                suma = 0;
            }
            Console.WriteLine(digitos);
        }
    }
}


