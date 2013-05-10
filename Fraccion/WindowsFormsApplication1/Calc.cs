using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Calc
    {
        public int diagonal(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
        
       
        public int miltupo(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public int saldos(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public int porcenta(int valor1, int valor2)
        {
            return valor1 * valor2 / valor1;
        }

        public int millaje(int valor1, int valor2)
        {
            return valor1 * valor2 * valor1;
        }
        public int distancia(int valor1, int valor2)
        {
            return valor1 * valor2 * valor1 + valor2;
        }
    }
}
