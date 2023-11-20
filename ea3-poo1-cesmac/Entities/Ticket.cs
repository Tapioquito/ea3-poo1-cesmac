using ea3_poo1_cesmac.Entities.Enums;

namespace ea3_poo1_cesmac.Entities
{
    public class Ticket : BaseEntity
    {
        public Ticket(Movie movie, TicketType ticketType, double price, string hourofSession)
        {
            Movie = movie;
            Type = ticketType;
            HourofSession = hourofSession;
            Price = price;
        }
        public Ticket() { }
        public Movie Movie { get; set; }
        public TicketType Type { get; set; }
        public double Price { get; set; }
        public string HourofSession { get; set; }
        public virtual string SnackBarAccess()
        {
            if (Type != TicketType.Full)
            {
                return "Compre um ingresso VIP!";
            }
            return "Lanchonete liberada";
        }

    }
}
