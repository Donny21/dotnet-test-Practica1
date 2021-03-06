using System.Windows;
using Practica2.ModelView;

namespace Practica2.Views
{
    public partial class RoleView : Window
    {
        public RoleView()
        {
            InitializeComponent();
            RoleViewModel ModeloDatos = new RoleViewModel();
            this.DataContext = ModeloDatos; 
        }
    }
}