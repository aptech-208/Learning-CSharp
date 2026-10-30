using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_
{
    //internal abstract class AbstractClass
    //{
    //    public abstract void Connect();

    //    public void Disconnect()
    //    {
    //        Console.WriteLine("You Have Successfully Disconnected....");
    //    }
    //}

    //internal class ChildAbstract : AbstractClass
    //{
    //    public override void Connect()
    //    {
    //        Console.WriteLine("You Have Successfully Connected....");
    //    }
    //}

    interface IShow
    {
        void IPrint();
    }
    interface IPut
    {
        void IScreen();
    }
    internal class InterfaceT : IShow, IPut
    {
        public void IPrint()
        {
            Console.WriteLine("Interface Inheritance Multiple Parent IShow");
        }

        public void IScreen()
        {
            Console.WriteLine("Interface Inheritance Multiple Parent IPut");
        }
    }
}   
