using ea3_poo1_cesmac.Entities;
using ea3_poo1_cesmac.Entities.Enums;

namespace ea3_poo1_cesmac.Controllers
{
    public class MenuController
    {
        public Movie SelectMovie(Movie[] movies)
        {
            Console.WriteLine("Selecione dentre os filmes a seguir:");
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine((i + 1) + " - " + movies[i].Nome);
            }

            int f = int.Parse(Console.ReadLine());
            return movies[f - 1];
        }

        public double BuyTicket()
        {
            double sum = 0.0;
            int count = 0;

            while (true)
            {
                Console.WriteLine("Selecione os tipos de ingresso:");
                Console.WriteLine("1 - Inteira (24.00)");
                Console.WriteLine("2 - Meia (12.00)");

                int i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        sum += 24.0;
                        count++;
                        break;
                    case 2:
                        sum += 12.0;
                        count++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("Gostaria de sair?");
                Console.WriteLine("1 - Sim\n2 - Não");
                int opt = int.Parse(Console.ReadLine());

                if (opt == 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Selecione os tipos de ingresso:");
                    Console.WriteLine("1 - Inteira (24.00)");
                    Console.WriteLine("2 - Meia (12.00)");

                    i = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Número de ingressos comprados: " + count);
            Console.WriteLine("Valor da compra:" + sum);
            return sum;
        }
    }
}
