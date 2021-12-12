using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Calculadora

    {
      public void suma()
        {
            int a, b, resultado;
            Console.WriteLine("INTRODUCE TU PRIMER DIGITO");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUCE TU SEGUNDO DIGITO");
            b = int.Parse(Console.ReadLine());

            resultado = a + b;
            Console.WriteLine("EL RESULTADO DE LA SUMA DE ESTOS DOS DIGITOS ES: " + resultado);

            //Console.ReadKey(); 
        }
        //-------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------
        public void resta()//////////FUNCION RESTA//////////
        {
            int a, b, resultado;

            Console.WriteLine("INTRODUCE TU PRIMER DIGITO");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUCE TU SEGUNDO DIGITO");
            b = int.Parse(Console.ReadLine());

            resultado = a - b;
            Console.WriteLine("EL RESULTADO DE LA RESTA DE ESTOS DOS DIGITOS ES: " + resultado);

            //Console.ReadKey();

        }
        //-------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------

        public void multiplicacion1()/////////FUNCION MULTIPLICACION///////////////
        {
            int a, b, resultado;

            Console.WriteLine("INTRODUCE TU PRIMER DIGITO");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUCE TU SEGUNDO DIGITO");
            b = int.Parse(Console.ReadLine());

            resultado = a * b;
            Console.WriteLine("EL RESULTADO DE LA MULTIPLICACION DE ESTOS DOS DIGITOS ES: " + resultado);

            //Console.ReadKey();

        }
        //-------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------
        public void division()////////////FUNCION DIVISION///////////
        {
            int a, b, resultado;

            Console.WriteLine("INTRODUCE TU PRIMER DIGITO");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUCE TU SEGUNDO DIGITO");
            b = int.Parse(Console.ReadLine());

            if(b == 0)
            {
                Console.WriteLine("No puedes dividir por 0");
            } else
            {
                resultado = a / b;
                Console.WriteLine("EL RESULTADO DE LA DIVISION DE ESTOS DOS DIGITOS ES: " + resultado);
            }
            
            

            //Console.ReadKey();
        }

        }
}
