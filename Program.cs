using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hospital_Managment_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();//m4 mwgoda fl video
            Application.EnableVisualStyles();//zwdnaha
            Application.SetCompatibleTextRenderingDefault(false);//zwdnaha
            Application.Run(new Login());


            Person p1= new PatientClass(id, name,  age,  gender,  address);
            PatientClass.MakeDoctor(p1);




        }
    }
}