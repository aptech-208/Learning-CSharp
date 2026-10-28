using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_
{
    internal class Controller
    {
        //Polymorphism

        public string name;
        public string email;
        public string password;
        public void BioData(string uname, string uemail, string upassword)
        {
            this.name = uname;
            this.email = uemail;
            this.password = upassword;
        }

        public void PrintData()
        {
            Console.WriteLine("AdminName" + this.name);
            Console.WriteLine("AdminEmail" + this.email);
            Console.WriteLine("AdminPassword" + this.password);
        }

        public void Bike()
        {
            Console.WriteLine("Parents got a Bike");
        }

        public void Car()
        {
            Console.WriteLine("Parents got a Car");
        }
        public void House()
        {
            Console.WriteLine("Parents got a House");
        }
    }
}
