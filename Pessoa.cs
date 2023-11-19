using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    public class Pessoa
    {
        public double peso, altura, imc;
        public string nome = "";

        public double CalculoIMC()
        {
            return imc = peso/(altura * altura);
        }
        public string Situacao(double CalculoIMC)
        {
            string retorno;

            if(CalculoIMC <= 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if (CalculoIMC >= 18.6 && CalculoIMC < 25)
            {
                retorno = "Peso ideal";
            }
            else if (CalculoIMC >= 25 && CalculoIMC < 30)
            {
                retorno = "Levemente acima do peso";
            }
            else if (CalculoIMC >= 30 && CalculoIMC < 35)
            {
                retorno = "Obesidade I";
            }
            else if (CalculoIMC >= 35 && CalculoIMC < 40)
            {
                retorno = "Obesidade II";
            }
            else 
            {
                retorno = "Obesidade III";
            }
            return retorno;
        }

        public void Mensagem()
        {
            double imcFinal = CalculoIMC();
            string situacaoFinal = Situacao(imcFinal);
            Console.WriteLine($"Olá {nome}, seu IMC é de {imcFinal.ToString("F2")} e sua situação é {situacaoFinal}");
        }
    }
}