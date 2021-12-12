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
                    case "1"://AGENDA
                        {
                            agenda.menuAgenda();
                            break;
                        }









                    //-------------------------------------------------------------------------------------------
                    //-------------------------------------------------------------------------------------------
                    case "2":///////////////CONVERSOR DE UNIDADES/////////////////
                        {
                            Console.WriteLine("APARTADO CONVERSOR DE UNIDADES");
                            string converunid1;
                            do

                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("1:CONVERSOR DE MONEDAS\n2:CONVERSOR DE TEMPERATURAS\n0:ATRAS");
                                converunid1 = Console.ReadLine();
                                Console.Clear();
                                switch (converunid1)
                                {
                                    case "1"://CONVERSOR DE MONEDAS
                                        {
                                            Console.WriteLine("CONVERSOR DE MONEDAS");
                                            string convermoned;
                                            CONVERSORMONEDAS convermon = new CONVERSORMONEDAS();
                                            do
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("1:DOLAR A EURO\n2:DOLAR A PESO\n3:PESO A EURO\n4:PESO A DOLAR\n" +
                                                    "5: EURO A DOLAR \n6: EURO A PESO\n0:ATRAS ");
                                                convermoned = Console.ReadLine();
                                                Console.Clear();
                                                switch (convermoned)
                                                {
                                                    case "1":
                                                        {
                                                            Console.WriteLine("DOLAR A EURO");
                                                            convermon.dolarAeuro();
                                                            break;
                                                        }
                                                    case "2":
                                                        {
                                                            Console.WriteLine("DOLAR A PESO");
                                                            convermon.usdApeso();
                                                            break;
                                                        }
                                                    case "3":
                                                        {
                                                            Console.WriteLine("PESO A EURO");
                                                            convermon.pesoAeuro();
                                                            break;
                                                        }
                                                    case "4":
                                                        {
                                                            Console.WriteLine("PESO A DOLAR");
                                                            convermon.pesoAusd();
                                                            break;
                                                        }
                                                    case "5":
                                                        {
                                                            Console.WriteLine("EURO A DOLAR");
                                                            convermon.euroAdolar();
                                                            break;
                                                        }
                                                    case "6":
                                                        {
                                                            Console.WriteLine("EURO A PESO");
                                                            convermon.euroApeso();
                                                            break;
                                                        }
                                                    case "0":
                                                        {
                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("OPCION INCORRECTA");
                                                            break;
                                                        }

                                                        

                                                }
                                            } while (convermoned != "0");
                                            break;
                                        }

                                    case "2":///CONVERSOR DE TEMPERATURAS
                                        {
                                            Console.WriteLine("CONVERSOR DE TEMPERATURAS");
                                            string convertemp;
                                            conversortemperatura convert = new conversortemperatura();
                                            do
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("1:FAHRENHEIT A CELSIUS\n2:FAHRENHEIT A KELVIN\n3:KELVIN A CELSIUS\n4:KELVIN A FAHRENHEIT\n5: " +
                                                "CELIUS A KELVIN\n6: CELIUS A FAHRENHEIT\n0:ATRAS");
                                                convertemp = Console.ReadLine();
                                                Console.Clear();
                                                switch (convertemp)
                                                {
                                                    case "1":
                                                        {
                                                            Console.WriteLine("FAHRENHEIT A CELSIUS");
                                                            convert.fahrenheitCelsius();
                                                            break;
                                                        }
                                                    case "2":
                                                        {
                                                            Console.WriteLine("FAHRENHEIT A KELVIN");
                                                            convert.fahrenheitKelvin();
                                                            break;
                                                        }
                                                    case "3":
                                                        {
                                                            Console.WriteLine("KELVIN A CELSIUS");
                                                            convert.kelvinCelsius();
                                                            break;
                                                        }
                                                    case "4":
                                                        {
                                                            Console.WriteLine("KELVIN A FAHRENHEIT");
                                                            convert.kelvinFahrenheit();
                                                            break;
                                                        }
                                                    case "5":
                                                        {
                                                            Console.WriteLine("CELIUS A KELVIN");
                                                            convert.celsiusKelvin();
                                                            break;
                                                        }
                                                    case "6":
                                                        {
                                                            Console.WriteLine("CELIUS A FAHRENHEIT");
                                                            convert.celsiusFahrenheit();
                                                            break;
                                                        }
                                                    case "0":
                                                        {
                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("OPCION INCORRECTA");
                                                            break;
                                                        }

                                                }


                                            } while (convertemp != "0");
                                        }
                                        break;
                                    /////////////////////////////////////////////////////////////////
                                    //////////////////////DIDIDIDIDIDI//////////////////////////////
                                    ///////////////////////////////////////////////////////////////
                                    case "0":
                                        {
                                            
                                            break;
                                        }
                                    default:
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("OPCION INCORRECTA");
                                            break;
                                        }

                                        

                                        
                                }


                            } while (converunid1 != "0");break;
                            

                        }

                    //-------------------------------------------------------------------------------------------
                    //-------------------------------------------------------------------------------------------
                    case "3"://///////////////////CALCULADORA/////////////////////

                        {
                            Console.WriteLine("APARTADO CALCULADORA");
                            string calcusub;
                            Calculadora calcu = new Calculadora();
      
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("1:SUMA\n2:RESTA\n3:MULTIPLICACION\n4:DIVISION\n0:ATRAS");
                                calcusub = Console.ReadLine();
                                Console.Clear();
                                switch (calcusub)
                                {
                                    case "1":
                                        {
                                            Console.WriteLine("1:SUMANDO");
                                            calcu.suma();
                                            break;
                                        }
                                    case "2":
                                        {
                                            Console.WriteLine("2:RESTANDO");
                                            calcu.resta();
                                            break;
                                        }
                                    case "3":
                                        {
                                            Console.WriteLine("3:MULTIPLICANDO");
                                            calcu.multiplicacion1();
                                            break;
                                        }
                                    case "4":
                                        {
                                            Console.WriteLine("4:DIVIDIENDO");
                                            calcu.division();
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
                            } while (calcusub != "0");
                            break;

    {

                            }
                          
                        }
                    case "0":
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n*****************************************SALISTE DEL MEJOR PROGRAMA DEL MUNDO*******************************************");

                            Console.WriteLine("********************************************ALVARO JOAQUIN MINYETY 2021-0194********************************************");
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
