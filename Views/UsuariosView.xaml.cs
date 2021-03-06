using System.Windows;
using Practica2.ModelView;

namespace Practica2.Views
{
    public partial class UsuariosView : Window
    {
        public UsuariosView()
        {
            InitializeComponent();
            UsuarioViewModel ModeloDatos = new UsuarioViewModel();
            this.DataContext = ModeloDatos;
        }
    }
}