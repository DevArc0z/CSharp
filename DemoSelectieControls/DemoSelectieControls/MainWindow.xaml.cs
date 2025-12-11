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

namespace DemoSelectieControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _isPrefect;
        string _house;
        string _name;
        Companion _pet;
        int _friends;
        public MainWindow()
        {
            InitializeComponent();

            List<string> animals = new List<string>()
            {
                "Owl",
                "Cat",
                "Toad",
                "Rat",
                "Snake",
                "Dragon",
                "Spider",
                "Unicorn",
            };

            List<Companion> companions = new List<Companion>()
            {
                new Companion("Fang", new DateTime(2015, 6, 1), false),
                new Companion("Scabbers", new DateTime(2018, 3, 15), true),
                new Companion("Crookshanks", new DateTime(2017, 11, 30), false),
                new Companion("Unicron", new DateTime(2016, 12, 30), false),
                new Companion("Megatron", new DateTime(2004, 1, 30), true),
                new Companion("Magnetron", new DateTime(2001, 9, 11), false)
            };

            petComboBox.Items.Clear();
            foreach (Companion animal in companions)
            {
                petComboBox.Items.Add(animal);
            }

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //CheckBox isPrefectCheckBox = (CheckBox)sender;

            _isPrefect = isPrefectCheckBox.IsChecked == true;
            summaryTextBlock.Text = BuildResult(_name, _house, _isPrefect, _pet, _friends);

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton checkedRadioButton = (RadioButton)sender;
            _house = checkedRadioButton.Content.ToString();
            summaryTextBlock.Text = BuildResult(_name, _house, _isPrefect, _pet, _friends);
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _name = nameTextBox.Text;

            StringBuilder stringBuilder = new StringBuilder();
            summaryTextBlock.Text = BuildResult(_name, _house, _isPrefect, _pet, _friends);
        }

        private string BuildResult(string name, string house, bool isPrefect, Companion pet, int friends)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            if (isPrefect)
            {
                sb.Append(", prefect ");
            }
            else
            {
                sb.Append(", student ");
            }
            sb.Append(" of ");
            sb.Append(house);
            sb.Append($", with {friends} friends");
            if (pet == null)
            {
                sb.Append(", with no pet");
            }
            else
            {
                sb.Append($" with a pet {pet}");
            }

            return sb.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox petComboBox = (ComboBox)sender;

            if (petComboBox.SelectedIndex != -1)
            {
                Companion companion = (Companion) petComboBox.SelectedItem;
                if (companion != null)
                {
                    _pet = companion;
                }
            }
            summaryTextBlock.Text = BuildResult(_name, _house, _isPrefect, _pet, _friends);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(_name, _pet, _house, _isPrefect, _friends);

            ListBoxItem newStudent = new ListBoxItem()
            {
                Content = BuildResult(_name, _house, _isPrefect, _pet, _friends)
            };

            ListBoxItem studentObjectListBoxItem = new ListBoxItem()
            {
                Content = student
            };

            saveStudentListBox.Items.Add(student);
        }

        private void friendSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _friends = (int)friendSlider.Value;
            friendsTextBlock.Text = $"Number of friends: {_friends}";
            summaryTextBlock.Text = BuildResult(_name, _house, _isPrefect, _pet, _friends);
        }
    }
}