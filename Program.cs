using System.Globalization;

namespace Learning_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Now Create Object Here

            // Student Stu = new Student(); //constructor method
            //Stu.BioData();
            //Stu.Print("Abc");

            //UserController a = new UserController();
            //a.Bike();
            //a.Car();
            //a.House();
            //a.Business();

            //Controller controller = new Controller();
            //controller.Bike();
            //controller.Car();
            //controller.House();

            UserController User = new UserController();
            User.BioData("Xyz", "Xys@gmail.com", "Xyz#1");
            User.PrintData();

            FacultyController Admin = new FacultyController();
            Admin.BioData("XyzAdmin", "XyzAdmin@gmail.com", "XyzAdmin");
            Admin.PrintData();

        }
    }
}
