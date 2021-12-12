using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class CONVERSORMONEDAS
    {
        public void usdApeso()
        {
            //USD A PESOS
            int usd, peso = 57, total;
            Console.WriteLine("INTRODUCE LA CANTIDAD DE DOLARES QUE DESEAR CONVERTIR EN PESOS");
            usd = int.Parse(Console.ReadLine());
            total = usd * peso;
            Console.WriteLine(total);
            //Console.ReadLine();
        }
        public void pesoAusd()
        {
            //PESO A USD
            double usd1 = 0.018, peso1, total1;
            Console.WriteLine("INTRODUCE LA CANTIDAD DE PESOS QUE DESEAR CONVERTIR EN USD");
            peso1 = Convert.ToDouble(Console.ReadLine());
            total1 = usd1 * peso1;
            Console.WriteLine(total1);
            //Console.ReadLine();
        }
        public void euroAdolar()
        {
            //EURO A DOLAR
            double usd2 = 1.13, euro3, total3;
            Console.WriteLine("INTRODUCE LA CANTIDAD DE EUROS QUE DESEAR CONVERTIR EN DOLARES");
            euro3 = Convert.ToDouble(Console.ReadLine());
            total3 = usd2 * euro3;
            Console.WriteLine(total3);
            //Console.ReadLine();
        }
        public void dolarAeuro()
        {
            double euro = 0.89, dolar, total2;
            Console.WriteLine("INTRODUCE LA CANTIDAD DE DOLARES QUE DESEAR CONVERTIR EN EURO");
            dolar = Convert.ToDouble(Console.ReadLine());
            total2 = euro * dolar;
            Console.WriteLine(total2);
            //Console.ReadLine();
        }
        public void euroApeso()
        {
            int euro4 = 64, peso4, total4;
            Console.WriteLine("INTRODUCE LA CANTIDAD DE EUROS QUE DESEAR CONVERTIR EN PESOS");
            peso4 = int.Parse(Console.ReadLine());
            total4 = euro4 * peso4;
            Console.WriteLine(total4);
            //Console.ReadLine();
        }
        public void pesoAeuro()
        {
            double euro5 = 0.016, peso5, total5;
            Console.WriteLine("INTRODUCE LA CANTIDAD DE PESO QUE DESEAR CONVERTIR EN EURO");
            peso5 = Convert.ToDouble(Console.ReadLine());
            total5 = euro5 * peso5;
            Console.WriteLine(total5);
            //Console.ReadLine();
        }


    }
}
