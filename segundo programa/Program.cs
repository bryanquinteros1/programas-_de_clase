using System;
using System.Threading;
namespace clase132
{
    class Program
    {

        public static string Mid(string parametro,int startindex, int length) 

        {
            string result = parametro.Substring(startindex, length); 
            return result;
        }


        static void Main(string[] args)
        {
            string Nombre;
            string final;
            int letras = 0;
            int movimeitn = 0;
            int cantidad = 0;
            int posicion = 0;
            Console.Write("ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.SetCursorPosition(1, 12); 
            Console.Write(Nombre);

            cantidad = Nombre.Length;
            posicion = 60; 
            Nombre = Nombre.ToUpper(); 

            for (movimeitn = Nombre.Length; movimeitn > 1; movimeitn--) 
            {
                final = Mid(Nombre, movimeitn - 1, 1);   
                for (letras = cantidad; letras< posicion; letras++) 
                {
                    Console.SetCursorPosition(letras, 12);
                    Console.Write("" + final); 
                    Thread.Sleep(50); 
                }
                posicion = posicion + 1; 
                cantidad = cantidad + 1;



            }

            Console.WriteLine();
        }
    }
}
