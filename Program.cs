using System;
using CalculadoraIMC;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "João";
            p1.altura = 1.67;
            p1.peso = 70;
            p1.Mensagem();

            Pessoa p2 = new Pessoa();
            p2.nome = "Maria";
            p2.altura = 1.75;
            p2.peso = 62;
            p2.Mensagem();
        }
    }
}
