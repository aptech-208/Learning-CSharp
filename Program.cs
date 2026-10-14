using System.Globalization;

namespace Learning_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Your Sum");
            //string Sum1 = Console.ReadLine();
            //string Sum2 = Console.ReadLine();

            //int s1 = int.Parse(Sum1);
            //int s2 = int.Parse(Sum2);

            //Console.WriteLine("Enter Your Sum");
            //string operation = Console.ReadLine();

            //int Result;
            ////Console.WriteLine(Result);

            //if (operation == "+")
            //{
            //    Result = s1 + s2;
            //    Console.WriteLine(Result);
            //}
            //else if (operation == "-")
            //{
            //    Result = s1 - s2;

            //    Console.WriteLine(Result);
            //}
            //else if (operation == "*")
            //{
            //    Result = s1 * s2;

            //    Console.WriteLine(Result);
            //}
            //else if (operation == "/")
            //{
            //    Result = s1 / s2;

            //    Console.WriteLine(Result);
            //}
            //else
            //{
            //    Console.WriteLine("Unknown operation!");
            //}

            Console.Write("Input a Month Using Number To Know The Season: ");
            int Number = int.Parse(Console.ReadLine());

            switch (Number)
            case 11:
            case 12:
            case 1:
                Console.WriteLine("Currently Its Winter.");
                break;

            case 2:
            case 3:
            case 4:
                Console.WriteLine("Currently Its Autumn.");
                break;

            case 5:
            case 6:
            case 7:
                Console.WriteLine("Currently Its Spring.");
                break;

            case 8:
            case 9:
            case 10:
                Console.WriteLine("Currently Its Summer.");
                break;


            default:
                    Console.WriteLine("Unknown Number.");
                    break;

            }

            //switch (Number)
            //{
            //    case 11 or 12 or 1:
            //        {
            //            Console.WriteLine("Currently Its Winter.");
            //        }
            //        break;

            //    case 2 or 3 or 4:
            //        {
            //            Console.WriteLine("Currently Its Autumn.");
            //        }
            //        break;

            //    case 5 or 6 or 7:
            //        {
            //            Console.WriteLine("Currently Its Spring.");
            //        }
            //        break;

            //    case 8 or 9 or 10:
            //        {
            //            Console.WriteLine("Currently Its Summer.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Unknown Number.");
            //        break;

            }
        }
    }
}
