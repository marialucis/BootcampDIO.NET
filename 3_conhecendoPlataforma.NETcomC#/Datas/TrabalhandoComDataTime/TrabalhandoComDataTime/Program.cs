using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TrabalhandoComDataTime
{
    class Program
    {
        static void Main(string[] args)
        {

            
            DateTime data = DateTime.Today;
            DateTime data2 = DateTime.Now;

            //formatando datatime

            Console.WriteLine(data.ToString("dd/MM/yyy hh:mm:ss"));
            Console.WriteLine(data2.ToString("dd/MM/yyy hh:mm"));
            Console.WriteLine(data2);

           


            //formatando data e hora

            DateTime dta = DateTime.Now;

            Console.WriteLine(dta.ToLongDateString());
            Console.WriteLine(dta.ToLongTimeString());
            Console.WriteLine(dta.ToShortDateString());
            Console.WriteLine(dta.ToShortTimeString());



            //datetime com tryparse validação 

            string dt = "1995/05/05 18:00";
            bool sucesso = DateTime.TryParseExact(dt, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datas);
            Console.WriteLine(datas);

            if (sucesso)
            {
                Console.WriteLine($"Conversão realizada com sucesso! {datas}");
            }
            else
            {
                Console.WriteLine($"{dt} com um formato invalido");
            }

            Console.ReadLine();

        }
    }
}
