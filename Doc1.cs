using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Hospital_Managment_System
{
    public class Doctor1 : Person
    {
        public string Specialty { get; set; }
        public string PhoneNumber { get; set; }
        

        // Constructor
        public Doctor1(int id, string name, int age, string gender, string specialty, string phoneNumber)
            : base(id, name, age, gender)
        {
            Specialty = specialty;
            PhoneNumber = phoneNumber;
            
        }

        // Methods
        public override void DisplayInfo()
        {
            Console.WriteLine($"Doctor ID: {Id}, Name: {Name}, Age: {Age}, Gender: {Gender}, Specialty: {Specialty}, Phone Number: {PhoneNumber}");
        }
    }

}
