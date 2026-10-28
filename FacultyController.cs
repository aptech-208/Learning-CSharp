using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_
{
    internal class FacultyController:Controller
    {
        public void PrintData()
        {
            Console.WriteLine("Faculty_Name" + this.name);
            Console.WriteLine("Faculty_Email" + this.email);
            Console.WriteLine("Faculty_Password" + this.password);
        }
    }
}
