using System.Globalization;

namespace Learning_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Now Create Object Here

            // Student ali = new Student(); //constructor method
            //ali.BioData();
            //ali.Print("Abc");

            //UserController a = new UserController();
            //a.Bike();
            //a.Car();
            //a.House();
            //a.Business();

            Controller controller = new Controller();
            controller.Bike();
            controller.Car();
            controller.House();



        }
    }
}
