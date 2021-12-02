using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Agenda
    {
        //FUNCION PARA MOSTRAR MENU AGENDA
        public void menuAgenda()
        {
            String opcion = "";
            

            do
            {
                Console.WriteLine("APARTADO DE AGENDA\n 1:CONTACTOS\n 2:EVENTOS");
                opcion = Console.ReadLine();
                //Console.Clear();
                switch (opcion)
                {
                    case "1":
                        {
                            menuContactos();
                            break;
                        }

                        //FUNCION MENU EVENTO
                    case "2":
                        {
                            Console.WriteLine("EVENTOS");
                            break;
                        }
                    case "0":
                        {
                            Console.WriteLine("ATRAS");
                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("OPCION INCORRECTA\n");

                            break;
                        }

                }
            } while (opcion != "0");
        }

        //FUNCION PARA MOSTRAR MENU CONTACTOS
        public void menuContactos()
        {
            
            String opcion = "";


            do
            {
                Console.WriteLine("\n1:GUARDAR\n 2:BUSCAR");
                opcion = Console.ReadLine();
                //Console.Clear();
                switch (opcion)
                {
                    case "1":
                        {
                            guardarContacto();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("APARTADO CONVERSOR DE UNIDADES");
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
            } while (opcion != "0");
        }

        //FUNCION PARA GUARDAR CONTACTOS
        public void guardarContacto()
        {
            Console.WriteLine("GUARDAR CONTACTO");
        }
        
    }
}
