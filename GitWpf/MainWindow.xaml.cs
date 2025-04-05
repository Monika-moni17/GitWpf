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

namespace GitWpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Login_Click(object sender, RoutedEventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string password = txtPassword.Password;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter Email and Password.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        // Login success -> Open new window
        DashboardWindow dashboard = new DashboardWindow();
        dashboard.Show();
        this.Close();
    }

    private void Signin_Click(object sender, RoutedEventArgs e)
    {
        SigninPageWindow signinPage = new SigninPageWindow();
        signinPage.Show();
    }
}