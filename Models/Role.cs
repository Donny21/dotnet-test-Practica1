namespace Practica2.Models
{
    public class Role
    {
        public int Id{get; set;}
        public string Nombres{get; set;}

        public Role()
        {
            
        }

        public Role(int Id, string Nombres)
        {
            this.Id = Id;
            this.Nombres = Nombres;
        }
    }
}