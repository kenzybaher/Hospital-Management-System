using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System
{
   
        public class PatientClass : Person
        {
        string _address;
            public string Address { get; set; }
        public int id;
        public string name;
        public string gender;
        public int age;
        public string address;
           
            // Constructor
            public PatientClass(int id, string name, int age, string gender, string address)
                : base(id, name, age, gender)
            {
                Address = address;

                
                
            }
            Person p1 = new Person(id, name, age, gender);

            // Methods
            public void UpdateAddress(string newAddress)
            {
                Address = newAddress;
            _address = Address;
            }

            public void UpdateAddress()
            {
                Address = _address;
            
            }

        public override void DisplayInfo()
            {
                Console.WriteLine($"Patient ID: {Id}, Name: {Name}, Age: {Age}, Gender: {Gender}, Address: {Address}");
            }
        }


}

