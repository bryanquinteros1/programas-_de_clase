using System;
using System.Threading; 
namespace clase13
{
    class Program
    {
        public static void dibuja(int Cantidad) 
        {
            int Alto = 20;
            int Anch = 50; 
            int lineaari = 2; 
            int lineaiz = 2; 
            int F, C, A;

            for (A = 1; A <= Cantidad; A++)  
            {
                for (F = lineaiz; F <= Anch; F++) 
                {
                    Console.SetCursorPosition(F, Alto); Console.Write("l"); 
                    Console.SetCursorPosition(F, lineaari); Console.Write("o");
                }
                for (C = lineaari; C <= Alto; C++)  
                {
                    Console.SetCursorPosition(lineaiz, C); Console.Write("s");  
                    Console.SetCursorPosition(Anch, C); Console.Write("X"); 
                }
                lineaari = lineaari + 1; 
                Alto = Alto - 1;
                lineaiz = lineaiz + 1;
                Anch = Anch - 1;
            }//for principal
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            for(int tam =1; tam <9; tam++) 
            {
                dibuja(tam);
                Thread.Sleep(1000);


            }
            Console.SetCursorPosition(25, 24); 
            Console.Write("pulse una tecla");
        }

    }
}
