using Login.Models;
using Login.Services;
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
using System.Xml.Schema;

namespace Login
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string inputUsername = InputUsernameTextBox.Text;
            string inputPassword = InputWachtwoordBox.Password;
            if (UserManager.TryLogin(inputUsername, inputPassword))
            {
                ShowInfo("Inloggen gelukt!", Brushes.Green);
                ClearScreen();
            }
            else
            {
                ShowInfo("Inloggen mislukt: verkeerde gebruikersnaam en of wachtwoord.", Brushes.Red);
                ClearScreen();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string inputUsername = InputUsernameTextBox.Text;
            string inputPassword = InputWachtwoordBox.Password;

            if (UserManager.Register(inputUsername, inputPassword))
            {

                ShowInfo("Registratie gelukt!", Brushes.Green);
                ClearScreen();
            }
            else
            {
                ShowInfo("Registratie mislukt: gebruikersnaam bestaat al.", Brushes.Red);
            }
        }

        private void ClearScreen()
        {
            InputUsernameTextBox.Clear();
            InputWachtwoordBox.Clear();
        }

        private void ShowInfo(string info, SolidColorBrush color)
        {
            infoTextBlock.Text = info;
            infoTextBlock.Foreground = color;
        }
    }
}