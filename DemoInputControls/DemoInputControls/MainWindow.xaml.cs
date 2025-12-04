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

namespace DemoInputControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void doubleButton_Click(object sender, RoutedEventArgs e)
        {
            string textFromTextBox = inputTextBox.Text;

            bool isANumber = int.TryParse(textFromTextBox, out int numberFromTextBox);

            if (isANumber)
            {
                int doubledNumber = numberFromTextBox * 2;
                inputTextBox.Text = doubledNumber.ToString();
            }
            else
            {
                inputTextBox.Text += inputTextBox.Text;
            }

            inputTextBox.Background = Brushes.White;
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Background = Brushes.Red;
        }
    }
}