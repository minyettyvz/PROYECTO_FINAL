using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Evento
    {
        List<string> eventosList = new List<string>(); // DECLARACION DE LA VARIABLE QUE GUARDARA LOS CONTACTOS
        public void menuEventos()

        {

            String opcion = "";



            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n1:GUARDAR\n2:BUSCAR\n3:EDITAR\n4:BORRAR\n0:ATRAS");
                opcion = Console.ReadLine();
                //Console.Clear();
                switch (opcion)
                {
                    case "1":
                        {
                            guardarEvento();
                            break;
                        }
                    case "2":
                        {
                            buscarEvento();
                            break;

                        }
                    case "3":
                        {
                            editarEvento();
                            break;
                        }
                    case "4":
                        {
                            borrarEvento();
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
        //FUNCION PARA GUARDAR CONTACTOS
        public void guardarEvento()
        {
            string nombre, fecha, hora, lugar;
            Console.WriteLine("GUARDAR EVENTO");
            Console.WriteLine("INGRESE NOMBRE");
            nombre = Console.ReadLine();
            Console.WriteLine("INGRESE FECHA");
            fecha = Console.ReadLine();
            Console.WriteLine("INGRESE HORA");
            hora = Console.ReadLine();
            Console.WriteLine("INGRESE LUGAR");
            lugar = Console.ReadLine();

            eventosList.Add(nombre + ";" + fecha + ";" + hora + ";" + lugar); // SE GUARDAN TODOS LOS VALORES DE UN CONTACTO  SEPARADOS POR ;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("EVENTO GUARDADO!");
        }

        public void buscarEvento()
        {
            string busqueda;
            bool encontrado = false;

            Console.WriteLine("INGRESE EL EVENTO A BUSCAR");
            busqueda = Console.ReadLine();

            for (int i = 0; i < eventosList.Count; i++) // SE RECORRE CADA CONTACTO
            {
                string[] datosEvento;
                datosEvento = eventosList[i].Split(';'); // SE SEPARA CADA VALOR DEL CONTACTO Y SE GUARDA EN UN NUEVO ARRAY

                for (int j = 0; j < datosEvento.Length; j++) // SE RECORRE EL NUEVO ARRAY CREADO QUE AHORA TIENE TODOS LOS DATOS DE 1 SOLO CONTACTO
                {
                    if (datosEvento[j].ToLower() == busqueda.ToLower()) // SE VA COMPARANDO VALOR POR VALOR DE 1 CONTACTO CON LA VARIABLE BUSQUEDA
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("EVENTO ENCONTRADO:"); // SI ENCUENTRA EL VALOR SE MUESTRAN TODOS LOS DATOS DE ESE CONTACTO
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("EVENTO: " + datosEvento[0]);
                        Console.WriteLine("FECHA: " + datosEvento[1]);
                        Console.WriteLine("HORA: " + datosEvento[2]);
                        Console.WriteLine("LUGAR: " + datosEvento[3]);
                        encontrado = true;
                    }
                }
            }
            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EVENTO NO ENCONTRADO!!");
            }
        }


        public void editarEvento()
        {
            int numEventoEditar;
            Console.WriteLine("LOS EVENTOS QUE TIENE EN AGENDA SON:\n");
            for (int i = 0; i < eventosList.Count; i++) // SE RECORRE CADA CONTACTO
            {
                string[] datosEvento;
                datosEvento = eventosList[i].Split(';'); // SE SEPARA CADA VALOR DEL CONTACTO Y SE GUARDA EN UN NUEVO ARRAY

                // MOSTRAR TODOS LOS CONTACTOS
                Console.WriteLine("- EVENTO #" + (i + 1));
                Console.WriteLine("EVENTO: " + datosEvento[0]);
                Console.WriteLine("FECHA: " + datosEvento[1]);
                Console.WriteLine("HORA: " + datosEvento[2]);
                Console.WriteLine("LUGAR: " + datosEvento[3]);
                Console.WriteLine("=================");
            }
            Console.WriteLine("INGRESE EL NUMERO DEL EVENTO QUE DESEA EDITAR:\n");
            numEventoEditar = int.Parse(Console.ReadLine());

            if (numEventoEditar > eventosList.Count)//SI SE INTRODUCE UN NUMERO NO EXISTENTE......
            {
                Console.WriteLine("EVENTO NO EXISTE");
            }
            else
            {
                string[] datosEventoEditar;
                string n, f, h, l;
                datosEventoEditar = eventosList[numEventoEditar - 1].Split(';');
                Console.WriteLine("EDITAR NOMBRE ACTUAL(" + datosEventoEditar[0] + ") (PRESIONE ENTER PARA OBVIAR): ");//SI NO QUIERE EDITAR ESTE APARTADO DEJAR VACIO
                n = Console.ReadLine(); if (n == "") { n = datosEventoEditar[0]; }//SI EL USUARIO OBVIA EDITAR ESTE APARTADO MOSTRAR NOMBRE ACTUAL
                Console.WriteLine("EDITAR FECHA ACTUAL(" + datosEventoEditar[1] + ") (PRESIONE ENTER PARA OBVIAR): ");
                f = Console.ReadLine(); if (f == "") { f = datosEventoEditar[1]; }
                Console.WriteLine("EDITAR HORA ACTUAL(" + datosEventoEditar[2] + ") (PRESIONE ENTER PARA OBVIAR): ");
                h = Console.ReadLine(); if (h == "") { h = datosEventoEditar[2]; }
                Console.WriteLine("EDITAR LUGAR ACTUAL(" + datosEventoEditar[3] + ") (PRESIONE ENTER PARA OBVIAR): ");
                l = Console.ReadLine(); if (l == "") { l = datosEventoEditar[3]; }


                eventosList.RemoveAt(numEventoEditar - 1);//ELIMINACION DE DATO YA EDITADO
                eventosList.Add(n + ";" + f + ";" + h + ";" + l);//INTRODUCCION DE NUEVOS DATOS EDITADOS
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EVENTO EDITADO!!!!");
            }

        }

        public void borrarEvento()
        {
            int numEventoBorrar;
            Console.WriteLine("LOS EVENTOS QUE TIENE EN AGENDA SON:\n");
            for (int i = 0; i < eventosList.Count; i++) // SE RECORRE CADA CONTACTO
            {
                string[] datosEvento;
                datosEvento = eventosList[i].Split(';'); // SE SEPARA CADA VALOR DEL CONTACTO Y SE GUARDA EN UN NUEVO ARRAY

                // MOSTRAR TODOS LOS CONTACTOS
                Console.WriteLine("- EVENTO #" + (i + 1));
                Console.WriteLine("EVENTO: " + datosEvento[0]);
                Console.WriteLine("FECHA: " + datosEvento[1]);
                Console.WriteLine("HORA: " + datosEvento[2]);
                Console.WriteLine("LUGAR: " + datosEvento[3]);
                Console.WriteLine("=================");
            }
            Console.WriteLine("INGRESE EL NUMERO DEL EVENTO QUE DESEA BORRAR:\n");
            numEventoBorrar = int.Parse(Console.ReadLine());

            if (numEventoBorrar > eventosList.Count)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EL EVENTO NO EXISTE");
            }
            else
            {
                eventosList.RemoveAt(numEventoBorrar - 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EVENTO BORRADO!!");
            }

        }
    }
}
