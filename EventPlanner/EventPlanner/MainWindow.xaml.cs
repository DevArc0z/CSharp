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

namespace EventPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _typeEvents;
        string _nameEvents;
        int _amountOfPeople;
        public MainWindow()
        {
            InitializeComponent();

            List<string> eventTypes = new List<string>()
            {
                "Opera",
                "Festival",
                "Orkest"
            };
            foreach (var type in eventTypes)
            {
                EventTypeComboBox.Items.Add(new ComboBoxItem()
                {
                    Content = type
                });
            }
        }

        private void AddEventButton_Click(object sender, RoutedEventArgs e)
        {
            Events events = new Events();
            events.Name = EventNameTextBox.Text;

            if(EventTypeComboBox.SelectedIndex != -1)
            {
                ComboBoxItem item = (ComboBoxItem)EventTypeComboBox.SelectedItem;

                events.TypeEvents = item.Content.ToString();
            }

            string inputFromNumberOfPeople = AmountOfPeopleTextBox.Text;

            if(int.TryParse(inputFromNumberOfPeople, out int numberOfPeople))
            {
                events.AmountOfPeople = numberOfPeople;
            }
            else
            {
                MessageBox.Show("Please enter a valid number for Amount of People.");
                return;
            }

            EventListBox.Items.Add(events);
        }

        private void RemoveEventButton_Click(object sender, RoutedEventArgs e)
        {
            EventListBox.Items.Remove(EventListBox.SelectedItem);
        }

        private void Afsluiten(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DeletaAllEvents_Click(object sender, RoutedEventArgs e)
        {
            EventListBox.Items.Clear();
        }

        private void CreateDefaultEvent_Click(object sender, RoutedEventArgs e)
        {
            Events[] events = new Events[]
            {
                new Events() { Name = "Pkp", AmountOfPeople = 20000, TypeEvents = "Festival"},
                new Events(){ Name = "Carmina Burana", AmountOfPeople = 500, TypeEvents = "Opera"}
            };
            foreach(Events @event in events)
            {
                EventListBox.Items.Add(@event);
            }
        }
    }
}