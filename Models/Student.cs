using System;

namespace Practica2.Models
{
    public class Student : Person
    {
        public Student(){

        }

        public Student(string StudentId, string FirstName, string LastName, string Email, DateTime Birthday, string Gender, string Phone)
        : base(FirstName, LastName, Email, Birthday, Gender, Phone)
        {
            this.StudentId = StudentId;
        }

        private string _studentId;

        public string StudentId{
            get{
                return _studentId;
            }set{
                _studentId = value;
            }
        }
    }
}