using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterExam
{
    class Ticket
    {
        //properties

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableTickets{ get; set; }

        //Constructors

        public Ticket(string name, decimal price, int availableTickets) 
        {
            Name = name;
            Price = price;
            AvailableTickets = availableTickets;

        }

        public Ticket() { }


        //Metods

        public void BookingTicket()
        {

        }

        public override string ToString()
        {
            return $"{Name},{Price:c},{AvailableTickets}";
        }

    }
}
