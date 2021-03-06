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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Practica2.Models;
using Practica2.Views;

namespace Practica2
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

        public void VentanaUsuarios(object sender, RoutedEventArgs e){
            UsuariosView VentanaUsuarios = new UsuariosView();
            VentanaUsuarios.ShowDialog();
        }

        public void VentanaRoles(object sender, RoutedEventArgs e){
            RoleView VentanaRoles = new RoleView();
            VentanaRoles.ShowDialog();
        }
    }
}
