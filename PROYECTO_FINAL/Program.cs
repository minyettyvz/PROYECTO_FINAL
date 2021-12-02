using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcionMenu;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************ALVARO JOAQUIN MINYETY 2021-0194*******************");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------------------------------------------------------------------");

            Agenda agenda = new Agenda();//CREANDO VARIABLE Y LLAMANDO ARCHIVO

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("1:AGENDA");
                Console.WriteLine("2:CONVERSOR DE UNIDADES");
                Console.WriteLine("3:CALCULADORA");
                Console.WriteLine("0:SALIR");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.Write("************DIGITE SOLO EL NUMERO DE SU OPCION DESEADA**************:");

                opcionMenu = Console.ReadLine();
                Console.Clear();
                switch (opcionMenu) {
                    case "1":
                        {
                            agenda.menuAgenda();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("APARTADO CONVERSOR DE UNIDADES");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("APARTADO CALCULADORA");
                            break;
                        }
                    case "0":
                        {
                            Console.WriteLine("BYE!!!");
                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("OPCION INCORRECTA\n");

                            break;
                        }
                        
                }
            } while (opcionMenu != "0");









            Console.ReadKey();

        }
    }
}
