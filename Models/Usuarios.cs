namespace Practica2.Models
{
    public class Usuarios
    {
        public int Id{get; set;}
        public string UserName{get; set;}
        public bool Enable{get; set;}
        public string Nombres{get; set;}
        public string Apellidos{get; set;}
        public string Email{get; set;}

        public Usuarios()
        {
            
        }

        public Usuarios(int Id, string UserName, bool Enable, string Nombres, string Apellidos, string Email)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.Enable = Enable;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Email = Email;
        }
    }
}