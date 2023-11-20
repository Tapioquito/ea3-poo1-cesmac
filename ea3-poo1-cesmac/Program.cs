using System;

namespace ea3_poo1_cesmac
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            Movie[] filmes = new Movie[]
            {
                new Movie("Filme1", "Diretor1", "Descrição1", "Ação", 120, false),
                new Movie("Filme2", "Diretor2", "Descrição2", "Comédia", 90, true),
               
            };

            
            MenuController menuController = new MenuController();

           
            Movie selectedMovie = menuController.SelectMovie(filmes);

           
            double totalAmount = menuController.BuyTicket();

            
            Ticket ticket = new Ticket(selectedMovie, TicketType.Full, totalAmount, "18:00");

           
            Console.WriteLine($"Ingresso para o filme {ticket.Movie.Nome}");
            Console.WriteLine($"Tipo de ingresso: {ticket.Type}");
            Console.WriteLine($"Preço do ingresso: {ticket.Price}");
            Console.WriteLine($"Horário da sessão: {ticket.HourofSession}");
            Console.WriteLine($"Acesso à lanchonete: {ticket.SnackBarAccess()}");

        }
    }
}
