using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Service
    {
        public double CelsiustoFahrenheit(double num )
        {
            return (num * 9 / 5) + 32;
        }
        public double FahrenheittoCelsius(double num)
        {
            return ((num-32)*5/9);
        }


    }
}
