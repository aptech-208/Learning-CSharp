using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_
{
    internal class Collection
    {
        public void Collect()
        {
            //Create ArrayList
            //ArrayList Abc = new ArrayList();
            ////Now Store Data Into ArrayList
            //Abc.Add("Abc");
            //Abc.Add("Abc@gmail.com");
            //Abc.Add(20);


            //Abc.Remove("Abc@gmail.com");
            ////Console.WriteLine(Abc.Count);

            ////Console.WriteLine(Abc[1]);

            //foreach (dynamic i in Abc)
            //{
            //    Console.WriteLine(i);
            //}




            //Hashtable 


            //Hashtable data = new Hashtable();

            //data.Add("name", "Abc");
            //data.Add("email", "Abc@gmail.com");
            //data.Add("age", 20);
            //data.Add("address", "DHA");


            ////Console.WriteLine(data["age"]);


            //foreach (dynamic a in data.Keys)
            //{
            //    Console.WriteLine(a + " : " + data[a]);
            //}



            //Queue queue = new Queue();

            //queue.Enqueue(100);
            //queue.Enqueue(250);
            //queue.Enqueue(350);
            //queue.Enqueue(400);
            //queue.Enqueue(500);
            //queue.Enqueue(6);
            //queue.Enqueue(7);
            //queue.Enqueue(8);
            //queue.Enqueue(9);
            //queue.Enqueue(10);


            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            //Stack


            //Stack stack = new Stack();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);


            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //list


            List<string> list = new List<string>();

            list.Add("Abc");
            list.Add("Abc@gmail.com");
            list.Add("Abc123");


            list.Remove("Abc@gmail.com");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
