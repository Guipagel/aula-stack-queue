using System;
using System.Collections.Generic;
using System.Linq.Expressions;
// # Projeto Desafio "Paralelo"

// - Adicionar a opção de programação paralela no menu principal
// - Criar uma calculadora que poderá fazer até 100 números para uma única vez
//     - O usuário define a quantidade de operações que irá realizar
//     - Insere primeiro o numero
//     - Depois a operação
//     - Em seguida, o próximo numero
//     - Operação
//     - Numero
// - Ao finalizar a digitação dos números e operações, mostrar como ficou a linha completa
// - A calculadora poderá receber operações
// - A calculadora poderá receber operações de Adição, Subtração, Divisão, Multiplicação, potenciação (Math.Pow)
// - Deverá realizar tudo o que está na mesma prioridade em paralelo
// - Gerar para o usuário o resultado de cada passo realizado
// - Salvar todos os passos e o resultado, na ordem que foi feito pelo programa, em um arquivo.txt
// Observações:
//     1º Parêntesis;
//     2º Potenciação;
//     3º Multiplicações e Divisões; (da esquerda para a direita)
//     4º Somas e Subtrações. (da esquerda para a direita)

namespace aula_stack_queue.calculadora
{
    public static class MenuCalculadora
    {
        public static void Iniciar()
        {

            Console.WriteLine("Bem vindo a calculadora");
            Console.WriteLine("------------------------------------------------");

            Console.Write("Digite a quantidade de operações: ");
            var qtdOperacoes = Convert.ToInt32(Console.ReadLine());

            List<int> numeros = new List<int>();
            List<string> operacoes = new List<string>();

            for (var i = 0; i <= qtdOperacoes; i++)
            {
                Console.Write($"Número: ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));

                if (i != qtdOperacoes)
                {
                    Console.Write($"Operacao: ");
                    operacoes.Add(Console.ReadLine());
                }
            }

            foreach(string operacao in operacoes) 
            {
                if(operacao is "*")
                {
                    var indexOperacao = operacoes.IndexOf(operacao); // Pegar os dois index IndexOf(-1) +1
                }
            }
        }

    }
}

// SepararEmFuncoes(stringGlobal);

// public static void SepararEmFuncoes(string stringGlobal)
// {
//     for(var i = 0; i < stringGlobal.Length; i++)
//     {                                            
//         if(stringGlobal[i] == '*')
//         {
//             var numeroAEsquerda = Convert.ToInt16(stringGlobal[i-1]);
//             var numeroADireita = Convert.ToInt16(stringGlobal[i+1]);

//             Console.Write(numeroAEsquerda + "*" + numeroADireita);

//             var resultado = Multiplicacao(numeroAEsquerda, numeroADireita);

//             stringGlobal.Remove(i-1, 2);
//         }
//     }
// } 

// public static int Multiplicacao(int numeroAEsquerda, int numeroADireita) 
// {
//     return numeroAEsquerda * numeroADireita;
// }

// System.Data.DataTable table = new System.Data.DataTable();
// var resultado =  Convert.ToDouble(table.Compute(stringGlobal, String.Empty));            
// System.Console.WriteLine(resultado);