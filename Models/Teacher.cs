using System;

namespace Practica2.Models
{
    public class Teacher : Person
    {
        public Teacher(){

        }
        public Teacher(string TeacherId, string FirstName, string LastName, string Email, DateTime Birthday, string Gender, string Phone)
        : base(FirstName, LastName, Email, Birthday, Gender, Phone)
        {
            this.TeacherId = TeacherId;
        }

        private string _teacherId;

        public string TeacherId{
            get{
                return _teacherId;
            }set{
                _teacherId = value;
            }
        }
    }
}