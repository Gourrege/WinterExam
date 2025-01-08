using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterExam
{
    class VIPTicket : Ticket
    {
        //Properties

        public string AdditionalExtras { get; set; }
        public decimal AddiontalCost { get; set; }

        //Constructors

        public VIPTicket():base() 
        {
            

        }


        //Methods

        public override string ToString()
        {
            return $"{Name},{Price:c},{AvailableTickets},{AdditionalExtras},{AddiontalCost:c}";
        }
    }
}
