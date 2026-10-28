using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_
{
    internal class UserController : Controller
    {
        public void PrintData()
        {
            Console.WriteLine("UserName" + this.name);
            Console.WriteLine("UserEmail" + this.email);
            Console.WriteLine("UserPassword" + this.password);
        }
        public void Business()
        {
            Console.WriteLine("Xyz Have a Business");
        }
    }
}
