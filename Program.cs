using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja saber a tabuada de que número?: ");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;

            for(int contador = 10; contador> 0; contador--){
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado} ");
            }
        }
    }
}
