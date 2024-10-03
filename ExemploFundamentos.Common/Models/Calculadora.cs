using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {potencia} ");
        }

        public void Seno(double angulo)
        {

            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);

            Console.WriteLine($"O seno de {angulo}º é igual a = {Math.Round(seno,4)}");

        }

        public void Coseno(double angulo)
        {

            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);

            Console.WriteLine($"O seno de {angulo}º é igual a = {Math.Round(coseno,4)}");

        }

        public void Tangente(double angulo)
        {

            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);

            Console.WriteLine($"O seno de {angulo}º é igual a = {tangente.ToString("0.00")}");

        }

        public void RaizQuadrada(double x)
        {

            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é {raiz}");

        }


    }
}
