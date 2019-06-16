using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seson = new string[12] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декбрь" };
            for (int i = 0; i <= 11; i++)
            {
                Console.WriteLine(seson[i]);
               
            }
            Console.ReadKey();
        }
    }
}
