using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._1_Laborator_16_.Models
{
    class Student
    {
        /*
         • Un student este caracterizat de
• Id (unic)
• Nume
• Prenume
• Varsta
• Specializare
    Specializarile vor fi
• Informatica
• Litere
• Constructii
*/


        public Guid ID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public MajorType Major { get; set; }
        public Student()
        {
            ID = Guid.NewGuid();
        }
        public enum MajorType
        {
            Informatics,
            Languages,
            Constructions
        }

        public override string ToString() =>
            $"{FirstName} {LastName}, age {Age}, majors in {Major}";
     }
}
