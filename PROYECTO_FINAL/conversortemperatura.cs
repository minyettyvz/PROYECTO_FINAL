using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class conversortemperatura
    {
        public void celsiusFahrenheit()//CELSIUS A FAHRENHEIT
        {
            double celsius, fahrenheit;
            Console.WriteLine("INTRODUCE LA CANTIDAN DE CELSIUS QUE DESEAS LLEVAR A FAHRENHEIT");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(fahrenheit);
           

        }
        public void fahrenheitCelsius()//FAHRENHEIT A CELSIUS
        {
            double celsius1, fahrenheit1;
            Console.WriteLine("INTRODUCE LA CANTIDAN DE FAHRENHEIT QUE DESEAS LLEVAR A CELSIUS");
            fahrenheit1 = Convert.ToDouble(Console.ReadLine());
            celsius1 = (fahrenheit1 - 32) * 5 / 9;
            Console.WriteLine(celsius1);
        }
        public void fahrenheitKelvin()//FAHRENHEIT A KELVIN
        {
            double fahrenheit2, kelvin;
            Console.WriteLine("INTRODUCE LA CANTIDAN DE FAHRENHEIT QUE DESEAS LLEVAR A KELVIN");
            fahrenheit2 = Convert.ToDouble(Console.ReadLine());
            kelvin = (fahrenheit2 - 32) * 5 / 9 + 273.15;
            Console.WriteLine(kelvin);
        }
        public void kelvinCelsius()//KELVIN A CELIUS
        {
            double kelvin1, celsius3;
            Console.WriteLine("INTRODUCE LA CANTIDAN DE KELVIN QUE DESEAS LLEVAR A CELSIUS");
            kelvin1 = Convert.ToDouble(Console.ReadLine());
            celsius3 = kelvin1 - 273.1;
            Console.WriteLine(celsius3);

        }
        public void kelvinFahrenheit()//KELVIN A FAHRENHEIT
        {
            double kelvin4, fahrenheit4;
            Console.WriteLine("INTRODUCE LA CANTIDAN DE KELVIN QUE DESEAS LLEVAR A FAHRENHEIT");
            kelvin4 = Convert.ToDouble(Console.ReadLine());
            fahrenheit4 = (kelvin4 - 273.15) * 9 / 5 + 32;
            Console.WriteLine(fahrenheit4);

        }
        public void celsiusKelvin()//CELSIUS A KELVIN
        {
            double celsius, kelvin;
            Console.WriteLine("INTRODUCE LA CANTIDAN DE CELSIUS QUE DESEAS LLEVAR A KELVIN");
            celsius = Convert.ToDouble(Console.ReadLine());
            kelvin = celsius + 273.15;
            Console.WriteLine(kelvin);


        }

    }
        
    
}
