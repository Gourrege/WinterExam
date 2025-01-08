using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterExam
{
    class Event : IComparable<Event>
    {
        //properties

        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; }
        public string TypeOfEvent { get; set; }
        public enum EventType { Music,Comedy,Theatre}

        //Constructors

        public Event() 
        {
            
        }

        //Method & IComparable

        public int CompareTo(Event? other)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{Name},{EventDate},{TypeOfEvent}";
        }

    }
}
