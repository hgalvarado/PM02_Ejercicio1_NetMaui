using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM02_Ejercicio1.Models
{
    internal class calculos
    {
        public double num1 {  get; set; }
        public double num2 { get; set; }

        public double suma(double num1, double num2) {
          
            return num1 + num2;
        }
        public double resta(double num1, double num2)
        {

            return num1 - num2;
        }
        public double multiplicacion(double num1, double num2)
        {

            return num1 * num2;
        }
        public double division(double num1, double num2)
        {
            if(num1==0|| num2 == 0)
            {
                return 0;
            }
            return num1 / num2;
        }
    }
}
