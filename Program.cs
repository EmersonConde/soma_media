using System;

namespace soma_media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Quantas notas serão analisadas?");
            int quantidade_notas = int.Parse(Console.ReadLine());

            //List<decimal> lista; declaração de lista
            //lista = new List<decimal>(); criação de estancias
            //var lista = new List<decimal>(); outra forma de criar lista
            //List<decimal> lista = new();

            //Adição de itens de coleção
            //lista.Add(5);

            /*
            Forma alternativa de acionar elementos a lista
            var lista = new List<decimal>()
            {
            5, -2, 9, 7
            };
            */
            List<decimal> listaDeValores = ColetarValores(quantidade_notas);
            Console.WriteLine($"Soma dos Valores é {Math.Round(CalcularSoma(listaDeValores),2)}");
            Console.WriteLine($"Média dos Valores é {Math.Round(CalcularMedia(listaDeValores), 2)}");
        }
        public static List<decimal> ColetarValores(int quantidade_notas)
        {
            List<decimal> listaDeValores = new List<decimal>(quantidade_notas);
            for (int i = 0; i < quantidade_notas; i++)
            {
                Console.Write($"Informe o valor {i+1}: ");
                listaDeValores.Add(decimal.Parse(Console.ReadLine()));

            }
            return listaDeValores;
        }
        static decimal CalcularSoma(List<decimal> listaDeValores)
        {
            decimal soma = 0;
            for(int i = 0; i < listaDeValores.Count; i++)
            {
                soma = soma + listaDeValores[i];
            }
            return soma;
        }
        static decimal CalcularMedia(List<decimal> listaDeValores)
        {
            decimal media;
            media = CalcularSoma(listaDeValores)/listaDeValores.Count;
            return media;
        }
    }
}