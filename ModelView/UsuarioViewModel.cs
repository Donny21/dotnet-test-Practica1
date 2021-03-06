using System.Collections.ObjectModel;
using System.ComponentModel;
using Practica2.Models;

namespace Practica2.ModelView
{
    //CREAMOS LA CLASE Y CREAMOS UNA INTERFASE PARA NOTIFICAR CUALQUIER CAMBIO
    public class UsuarioViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Usuarios> usuarios{get; set;}

        public UsuarioViewModel()
        {
            this.usuarios = new ObservableCollection<Usuarios>();
            this.usuarios.Add(new Usuarios(1, "DNY", true, "Esdras", "Jimenez", "esdrasjimenezaft@gmail.com"));
            this.usuarios.Add(new Usuarios(2, "Glad", true, "Gladys", "Rosales", "siomalararosales@hotmail.es"));
            this.usuarios.Add(new Usuarios(3, "Chucky", true, "Deivy", "Gurrion", "deivygurrion@gmail.com"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        //METODO PARA NOTIFICAR CAMBIOS
        public void NotificarCambio(string propiedad){
            if(PropertyChanged != null){
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
    }
}