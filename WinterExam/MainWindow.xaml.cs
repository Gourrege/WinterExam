using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WinterExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    //Testind GITHUB
    public partial class MainWindow : Window
    {
        List<Event> events = new List<Event>();

        public MainWindow()
        {
            InitializeComponent();
        }
        public void TestingGIT() { }

        private void Liam_and_Noels_Ticket_Oasis_Loaded(object sender, RoutedEventArgs e)
        {
            Event e1 = new Event() 
            {
                Name = "Oasis Croke Park",
                EventDate = new DateTime(2025,06,20),
                TypeOfEvent = Event.EventType.Music.ToString(),
                Tickets = new List<Ticket>()
            };
            Event e2 = new Event()
            {
                Name = "Electric Picnic",
                EventDate = new DateTime(2025, 08, 20),
                TypeOfEvent = Event.EventType.Music.ToString(),
                Tickets = new List<Ticket>()
            };
            Ticket t1 = new Ticket() 
            {
                Name = "Early Bird",
                Price = 100m,
                AvailableTickets = 100
            };
            Ticket t2 = new Ticket()
            {
                Name = "Platinium",
                Price = 150m,
                AvailableTickets = 100
            };
            VIPTicket vT1 = new VIPTicket()
            {
                Name = "Ticket and Hotel Package",
                Price = 150m,
                AvailableTickets = 100,
                AdditionalExtras = "4*Hotel",
                AddiontalCost = 100m
                
            };
            VIPTicket vT2 = new VIPTicket()
            {
                Name = "Weekend Ticket",
                Price = 200m,
                AvailableTickets = 100,
                AdditionalExtras = "with camping",
                AddiontalCost = 100m

            };

            e1.Tickets.Add(t1);
            e1.Tickets.Add(t2);
            e1.Tickets.Add(vT1);
            e1.Tickets.Add(vT2);
            e2.Tickets.Add(t1);
            e2.Tickets.Add(t2);
            e2.Tickets.Add(vT1);
            e2.Tickets.Add(vT2);
            events.Add(e1);
            events.Add(e2);



            lstbxTickets.ItemsSource = e1.Tickets;
            lstbxTickets.ItemsSource = e2.Tickets;
            lstbxEvents.ItemsSource = events;

        }

        private void lstbxTickets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Ticket selected = lstbxTickets.SelectedItem as Ticket;
            if (selected != null)
            {
                
            }
        }
    }
}