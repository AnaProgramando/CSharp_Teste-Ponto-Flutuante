using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_TestaPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\n Exercício - Teste de Ponto Flutuante \r\n");

            Console.WriteLine("================================================================= \r\n \r\n");


            Console.WriteLine("Teste de Ponto Flutuante motrando um valor com decimais: \r\n");

            double salario;
            salario = 1250.70;
            Console.WriteLine("O salário em formato double é de " + salario + "." + "\r\n \r\n");
            
            Console.WriteLine("--------------------------------------------------------------- \r\n \r\n");

            Console.WriteLine("Como não podemos colocar um valor com ponto flutuante dentro de uma variável do tipo int, seguem as observações: \r\n");

            Console.WriteLine("-> int valor = 12.5");
            Console.WriteLine("Quando declaramos 12.5 como int, o código NÃO compila. \r\n \r\n");

            Console.WriteLine("-> int valor = 0.0");
            Console.WriteLine("Quando declaramos 0.0 como int, o código NÃO compila. \r\n \r\n");

            double teste;
            teste = 125.50;
            Console.WriteLine("-> double teste = 125.50");
            Console.WriteLine("Quando declaramos 125.50 como double, o código compila. \r\n \r\n");

            int valor;
            Console.WriteLine("-> teste2 = 78.5");
            Console.WriteLine("-> int valor = teste2");
            Console.WriteLine("Quando declaramos valor como int e tentamos adicionar um número com casas decimais, o código NÃO compila. \r\n \r\n");


            Console.WriteLine("--------------------------------------------------------------- \r\n \r\n");
            
            Console.WriteLine("Teste de Ponto Flutuante com divisão \r\n");

            int divisaoerrada;
            divisaoerrada = 5 / 2;
            Console.WriteLine("-> int divisao = 5 / 2 = " + divisaoerrada + ".");
            Console.WriteLine("Quando fazemos uma divisão com números inteiros, o CSharp sempre truncará o resultado, deixando ele sem vírgula e incorreto. \r\n \r\n");

            double divisaocerta;
            divisaocerta = 5.0 / 2.0;
            Console.WriteLine("->  double divisao = 5.0. / 2.0 = " + divisaocerta + ".");
            Console.WriteLine("Colocando os valores da divisão com casas decimais, e mudando o tipo da variável para double, o resultado é exibido da forma correta. \r\n \r\n");

            Console.WriteLine("--------------------------------------------------------------- \r\n \r\n");

            Console.WriteLine("Programa executado! Pressione enter para sair.");
            Console.ReadLine();
        }
    }
}
