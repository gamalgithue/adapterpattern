using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
     class Adapter:Itarget
    {

        private Service _Service1;
        public Adapter(Service _service)
        {
            this._Service1 = _service;
        }
   
       
        public string Request(double num1)
        {
                return _Service1.CelsiustoFahrenheit(num1) + " F".ToString();

            }

        public string Request1(double num1)
        {
            return _Service1.FahrenheittoCelsius(num1) + " C".ToString();

        }


    }
       
    }

