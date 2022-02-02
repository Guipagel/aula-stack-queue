using System;
using aula.ordenacao.Busca;

namespace aula.ordenacao
{
    public class Menu
    {
        public static void Iniciar()
        {
            Console.ReadLine();

            Console.WriteLine("1 - Busca");
            Console.WriteLine("2 - Ordenação");

            switch (Console.Read())
            {
                case '1':
                    Console.ReadLine();
                    Busca.Menu.IniciarBusca();
                    break;
                case '2':
                    Console.ReadLine();
                    Ordenacao.Menu.IniciarOrdenacao();
                    break;

                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            Iniciar();
        }
    }
}