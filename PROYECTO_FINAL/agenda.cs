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
            Contactos contactos = new Contactos();
            Evento eventos = new Evento();

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("APARTADO DE AGENDA\n1:CONTACTOS\n2:EVENTOS\n0:ATRAS");
                opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        {
                            contactos.menuContactos();
                            break;
                        }

                        //FUNCION MENU EVENTO
                    case "2":
                        {
                            eventos.menuEventos();
                            break;
                        }
                    case "0":
                        {
                            
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



        
        

        
        }
        
    
}
