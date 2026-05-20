using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }

            // Constructor
            public Person(int id, string name, int age, string gender)
            {
                Id = id;
                Name = name;
                Age = age;
                Gender = gender;
            }
        public Person() { }

       
        public virtual void DisplayInfo() { }
        public static Doctor1 MakeDoctor(Person person, string specialty, string phoneNumber)
        {
            Doctor1 doc;
            doc.Specialty = specialty;
            doc.PhoneNumber = phoneNumber;
            doc.Name = person.Name;
            doc.Id = person.Id;
            return doc;
        }

        }


    }

