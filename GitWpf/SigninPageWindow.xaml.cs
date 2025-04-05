using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GitWpf
{
    /// <summary>
    /// Interaction logic for SigninPageWindow.xaml
    /// </summary>
    public partial class SigninPageWindow : Window
    {
        public SigninPageWindow()
        {
            InitializeComponent();
        }

        private void Signin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Signin Sucessfully");
            return;
        }

        // signin success -> Open mainwindow
        

        
    }

   
    }

