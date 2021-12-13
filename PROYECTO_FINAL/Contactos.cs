using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Contactos
    {
        List<string> contactosList = new List<string>(); // DECLARACION DE LA VARIABLE QUE GUARDARA LOS CONTACTOS
        public void menuContactos()

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
                            guardarContacto();
                            break;
                        }
                    case "2":
                        {
                            buscarContacto();
                            break;

                        }
                    case "3":
                        {
                            editarContacto();
                            break;
                        }
                    case "4":
                        {
                            borrarContacto();
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
        public void guardarContacto()
        {
            string nombre, apellido, telefono, direccion, email;
            Console.WriteLine("GUARDAR CONTACTO");
            Console.WriteLine("INGRESE SU NOMBRE");
            nombre = Console.ReadLine();
            Console.WriteLine("INGRESE SU APELLIDO");
            apellido = Console.ReadLine();
            Console.WriteLine("INGRESE SU TELEFONO");
            telefono = Console.ReadLine();
            Console.WriteLine("INGRESE SU DIRECCION");
            direccion = Console.ReadLine();
            Console.WriteLine("INGRESE SU EMAIL");
            email = Console.ReadLine();

            contactosList.Add(nombre + ";" + apellido + ";" + telefono + ";" + direccion + ";" + email); // SE GUARDAN TODOS LOS VALORES DE UN CONTACTO  SEPARADOS POR ;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CONTACTO GUARDADO!");
        }

        public void buscarContacto()
        {
            string busqueda;
            bool encontrado = false;

            Console.WriteLine("INGRESE EL CONTACTO A BUSCAR");
            busqueda = Console.ReadLine();

            for (int i = 0; i < contactosList.Count; i++) // SE RECORRE CADA CONTACTO
            {
                string[] datosContacto;
                datosContacto = contactosList[i].Split(';'); // SE SEPARA CADA VALOR DEL CONTACTO Y SE GUARDA EN UN NUEVO ARRAY

                for (int j = 0; j < datosContacto.Length; j++) // SE RECORRE EL NUEVO ARRAY CREADO QUE AHORA TIENE TODOS LOS DATOS DE 1 SOLO CONTACTO
                {
                    if (datosContacto[j].ToLower() == busqueda.ToLower()) // SE VA COMPARANDO VALOR POR VALOR DE 1 CONTACTO CON LA VARIABLE BUSQUEDA
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("CONTACTO ENCONTRADO:"); // SI ENCUENTRA EL VALOR SE MUESTRAN TODOS LOS DATOS DE ESE CONTACTO
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("NOMBRE: " + datosContacto[0]);
                        Console.WriteLine("APELLIDO: " + datosContacto[1]);
                        Console.WriteLine("TELEFONO: " + datosContacto[2]);
                        Console.WriteLine("DIRECCION: " + datosContacto[3]);
                        Console.WriteLine("EMAIL: " + datosContacto[4]);
                        encontrado = true;
                    }
                }
            }
            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CONTACTO NO ENCONTRADO!!");
            }
        }


        public void editarContacto()
        {
            int numContactoEditar;
            Console.WriteLine("LOS CONTACTOS QUE TIENE EN AGENDA SON:\n");
            for (int i = 0; i < contactosList.Count; i++) // SE RECORRE CADA CONTACTO
            {
                string[] datosContacto;
                datosContacto = contactosList[i].Split(';'); // SE SEPARA CADA VALOR DEL CONTACTO Y SE GUARDA EN UN NUEVO ARRAY

                // MOSTRAR TODOS LOS CONTACTOS
                Console.WriteLine("- CONTACTO #" + (i + 1));
                Console.WriteLine("NOMBRE: " + datosContacto[0]);
                Console.WriteLine("APELLIDO: " + datosContacto[1]);
                Console.WriteLine("TELEFONO: " + datosContacto[2]);
                Console.WriteLine("DIRECCION: " + datosContacto[3]);
                Console.WriteLine("EMAIL: " + datosContacto[4]);
                Console.WriteLine("=================");
            }
            Console.WriteLine("INGRESE EL NUMERO DEL CONTACTO QUE DESEA EDITAR:\n");
            numContactoEditar = int.Parse(Console.ReadLine());

            if (numContactoEditar > contactosList.Count)//SI SE INTRODUCE UN NUMERO NO EXISTENTE......
            {
                Console.WriteLine("CONTACTO NO EXISTE");
            }
            else
            {
                string[] datosContactoEditar;
                string n, a, t, d, e;
                datosContactoEditar = contactosList[numContactoEditar - 1].Split(';');
                Console.WriteLine("EDITAR NOMBRE ACTUAL(" + datosContactoEditar[0] + ") (PRESIONE ENTER PARA OBVIAR): ");//SI NO QUIERE EDITAR ESTE APARTADO DEJAR VACIO
                n = Console.ReadLine(); if (n == "") { n = datosContactoEditar[0]; }//SI EL USUARIO OBVIA EDITAR ESTE APARTADO MOSTRAR NOMBRE ACTUAL
                Console.WriteLine("EDITAR APELLIDO ACTUAL(" + datosContactoEditar[1] + ") (PRESIONE ENTER PARA OBVIAR): ");
                a = Console.ReadLine(); if (a == "") { a = datosContactoEditar[1]; }
                Console.WriteLine("EDITAR TELEFONO ACTUAL(" + datosContactoEditar[2] + ") (PRESIONE ENTER PARA OBVIAR): ");
                t = Console.ReadLine(); if (t == "") { t = datosContactoEditar[2]; }
                Console.WriteLine("EDITAR DIRECCION ACTUAL(" + datosContactoEditar[3] + ") (PRESIONE ENTER PARA OBVIAR): ");
                d = Console.ReadLine(); if (d == "") { d = datosContactoEditar[3]; }
                Console.WriteLine("EDITAR EMAIL ACTUAL(" + datosContactoEditar[4] + ") (PRESIONE ENTER PARA OBVIAR): ");
                e = Console.ReadLine(); if (e == "") { e = datosContactoEditar[4]; }


                contactosList.RemoveAt(numContactoEditar - 1);//ELIMINACION DE DATO YA EDITADO
                contactosList.Add(n + ";" + a + ";" + t + ";" + d + ";" + e);//INTRODUCCION DE NUEVOS DATOS EDITADOS
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CONTACTO EDITADO!!!!");
            }

        }

        public void borrarContacto()
        {
            int numContactoBorrar;
            Console.WriteLine("LOS CONTACTOS QUE TIENE EN AGENDA SON:\n");
            for (int i = 0; i < contactosList.Count; i++) // SE RECORRE CADA CONTACTO
            {
                string[] datosContacto;
                datosContacto = contactosList[i].Split(';'); // SE SEPARA CADA VALOR DEL CONTACTO Y SE GUARDA EN UN NUEVO ARRAY

                // MOSTRAR TODOS LOS CONTACTOS
                Console.WriteLine("- CONTACTO #" + (i + 1));
                Console.WriteLine("NOMBRE: " + datosContacto[0]);
                Console.WriteLine("APELLIDO: " + datosContacto[1]);
                Console.WriteLine("TELEFONO: " + datosContacto[2]);
                Console.WriteLine("DIRECCION: " + datosContacto[3]);
                Console.WriteLine("EMAIL: " + datosContacto[4]);
                Console.WriteLine("=================");
            }
            Console.WriteLine("INGRESE EL NUMERO DEL CONTACTO QUE DESEA BORRAR:\n");
            numContactoBorrar = int.Parse(Console.ReadLine());

            if (numContactoBorrar > contactosList.Count)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CONTACTO NO EXISTE");
            }
            else
            {
                contactosList.RemoveAt(numContactoBorrar - 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CONTACTO BORRADO!!");
            }

        }
    }
}
