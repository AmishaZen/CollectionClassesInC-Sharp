using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionInDotNet
{
    class StackAndQueue
    {
        static void Main(string[] args)
        {
            Stack st = new Stack(new string[] { "sun","Mon","Tue","thru","Fri"});
            st.Push("sat");
            st.Push("The days of the week");
            Console.WriteLine("Elements of Stack is");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("printing value using getEnumerator");
            IEnumerator ie = st.GetEnumerator();
            while(ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine($"it pop one element :{st.Pop()}");
            Console.WriteLine("after pop elements are");
            IEnumerator iee = st.GetEnumerator();
            while (iee.MoveNext())
            {
                Console.WriteLine(iee.Current);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"top of stack is :{st.Peek()}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Printing elements of stack third way ");
            while(st.Count>0)
            {
                Console.WriteLine(st.Pop());
            }

            Queue que = new Queue(new int[] { 2,3,4,5,6 });
            //Enqueue
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Enqueue element at the end:");
            que.Enqueue(55);
            IEnumerator i = que.GetEnumerator();
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);
            }

            //Dequeue
            Console.WriteLine("----------------------------------");
            Console.WriteLine("dequeue element:");
            que.Dequeue();
            IEnumerator iE = que.GetEnumerator();
            while (iE.MoveNext())
            {
                Console.WriteLine(iE.Current);
            }

            //Count
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"count of element is : {que.Count}");

            //Peek
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"top of queue is :{que.Peek()}");

            //Clear
            Console.WriteLine("----------------------------------");
            Console.WriteLine("cleared the element");
            que.Clear();
            IEnumerator e = que.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }

            //Count
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"count of element is : {que.Count}");


            //Indexer
            Console.WriteLine("Use of Indexer using ArrayList");
            var idx = new ArrayList(new string[12]);
            idx[0] = "Greet";
            idx[1] = "Everyone";
            idx[2] = "with";
            idx[3] = "good morning";

            foreach (var item in idx)
            {
                Console.WriteLine(item);
            }
        }
    }
}
