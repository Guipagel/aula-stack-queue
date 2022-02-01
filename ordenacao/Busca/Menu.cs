using System;

namespace aula.ordenacao.Busca
{
    public class Menu
    {
        static int[] elementos = new int[10];

        public static void IniciarBusca() {
            Console.ReadLine();
            
            Console.WriteLine("Busca...");

            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Linear Search...");
            Console.WriteLine("2. Binary Search...");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    Console.ReadLine();
                    for(int i=0;i < elementos.Length; i++) {
                        Console.WriteLine("Insira o numero da posição {0} ...", i);
                        elementos[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Insira o valor de deseja buscar...");
                    BuscaLinear.linearSearch(Convert.ToInt32(Console.ReadLine()), elementos);
                    break;
                case '2':
                    Console.ReadLine();
                    for(int i=0;i < elementos.Length; i++) {
                        Console.WriteLine("Insira o numero da posição {0} ...", i);
                        elementos[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Insira o valor de deseja buscar...");
                    BuscaBinaria.binarySearch(Convert.ToInt32(Console.ReadLine()), elementos);                    
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            IniciarBusca();
        }
    }
}