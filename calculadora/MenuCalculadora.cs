using System;
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

        public static void Iniciar(){
            
            Console.WriteLine("Bem vindo a calculadora");
            Console.WriteLine("------------------------------------------------");
            
            Console.WriteLine("Digite a quantidade de operações: ");
            int qtdOperacoes;
            qtdOperacoes = Convert.ToInt32(Console.ReadLine());
            
            string stringOperacao = "";

            for(var i = 0; i <= qtdOperacoes ; i++)
            {
                Console.WriteLine($"Número: ");
                var numero = Convert.ToInt32(Console.ReadLine());

                var operacao = "";
                if(i != qtdOperacoes){
                    Console.WriteLine($"Operacao: ");
                    operacao = Console.ReadLine();
                }
                
                stringOperacao = string.Concat(stringOperacao, $"{numero}{operacao}");
            }
            
            SepararEmFuncoes(stringOperacao);
            // System.Data.DataTable table = new System.Data.DataTable();
            // var resultado =  Convert.ToDouble(table.Compute(stringOperacao, String.Empty));
            
            // System.Console.WriteLine(resultado);
        }

        public static void SepararEmFuncoes(string stringOperacao)
        {
            System.Console.WriteLine($"Tamanho string = {stringOperacao.Length}");
            var stringOperacaoClone = Convert.ToString(stringOperacao);

            for(var i = 0; i < stringOperacao.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"{stringOperacao[i]}");
                
                if(stringOperacao[i] == '*')
                {
                    var numeroAEsquerda = stringOperacao[i-1];
                    var numeroADireita = stringOperacao[i+1];
                    System.Console.WriteLine($"numeroAEsquerda: {numeroAEsquerda} // numeroADireita: {numeroADireita}");
                }
            }
        } 
    }
}