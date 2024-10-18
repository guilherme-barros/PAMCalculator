using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMCalculator.Models
{
    public class Calculator
    {
        public double PrimeiroTermo { get; set; }
        public double SegundoTermo { get; set; }
        public double Resultado { get; set; }

        public double Somar(double n1, double n2) {
            PrimeiroTermo = n1;
            SegundoTermo = n2;
            Resultado = n1 + n2;
            return Resultado;
        }

        public double Subtrair(double n1, double n2) {
            PrimeiroTermo = n1;
            SegundoTermo = n2;
            Resultado = n1 - n2;
            return Resultado;   
        }

        public double Multiplicar(double n1, double n2) {
            PrimeiroTermo = n1;
            SegundoTermo = n2;
            Resultado = n1 * n2;
            return Resultado;
        }

        public double Dividir(double n1, double n2) {
            PrimeiroTermo = n1;
            SegundoTermo = n2;
            Resultado = PrimeiroTermo / SegundoTermo;
            return Resultado;
        }

        public double Elevar(double n1, double n2) {
            PrimeiroTermo = n1;
            SegundoTermo = n2;
            Resultado = n1;
            for (int i = 1; i < n2; i++)
            {
                Resultado = PrimeiroTermo * Resultado;
            }
            return Resultado;
        }

        public double Raiz(double n1, double n2)
        {
            PrimeiroTermo = n1;//radicando
            SegundoTermo = n2;//indice
            Resultado = n1 * (-1);
            
            for (int i = 1; i < n2; i++)
            {
                Resultado = Math.Pow(n2, 1 / n1);
            }
            return Resultado;
        }
    }
}
