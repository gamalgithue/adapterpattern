using System;
using System.Threading.Tasks;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Data.Sql;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
namespace ConsoleApp19
{
    class program
    {

        static void Main(string[] args)
        {
            Service Servic1 = new Service();
            Itarget target = new Adapter(Servic1);
            Console.WriteLine("What type of Convert\n1-CelsiustoFahrenheit\n" +
                "2-FahrenheittoCelsius");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 == 1)
            {
                Console.WriteLine("Enter the value of Temperature");

                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(target.Request(num2));

            }
            else if (num3 == 2)
            {
                Console.WriteLine("Enter the value of Temperature");

                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(target.Request1(num2));
            }
            else
            {
                Console.WriteLine("you must enter a number");
            }


        }
    }

}