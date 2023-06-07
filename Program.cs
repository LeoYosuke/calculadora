using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leoleoleo4Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float coxinha = 5.50f;
            float ac_catupiry = 2.5f;
            float coxinha_catupiry = coxinha + ac_catupiry;
            Console.WriteLine($"a coxinha custa R$ {coxinha}");
            Console.WriteLine($"adicionar catupiry R$ {ac_catupiry}");
            Console.WriteLine($"coxinha com catupiry R$ {coxinha_catupiry}");

            float peso = 55.5f;
            float altura = 1.70f;
            float imc = peso / (altura * altura);
            Console.WriteLine($"meu IMC é {imc} ");


            Console.ReadKey();
        }
    }
}
