using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Agenda
    {
        List<string> contactos = new List<string>();
        string[] contactos2 = new string[2];
        //FUNCION PARA MOSTRAR MENU AGENDA
        public void menuAgenda()
        {
            String opcion = "";
            

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
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n1:GUARDAR\n2:BUSCAR");
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
                            buscarContacto();
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
            string nombre, apellido;
            string[] klk;
            Console.WriteLine("GUARDAR CONTACTO");
            Console.WriteLine("INGRESE SU NOMBRE");
            nombre = Console.ReadLine();
            Console.WriteLine("INGRESE SU APELLIDO");
            apellido = Console.ReadLine();

            contactos.Add(nombre+";"+apellido);
            contactos2 = new string[] { nombre,apellido};
            

            for (int i = 0; i < contactos2.Length; i++)
            {
                Console.WriteLine(contactos2[i]);
            }
            
        }

        public void buscarContacto()
        {
            string valor;
            Console.WriteLine("INGRESE EL CONTACTO A BUSCAR");
            valor = Console.ReadLine();

            Console.WriteLine(contactos.IndexOf(valor, 0));

        }
        
    }
}
