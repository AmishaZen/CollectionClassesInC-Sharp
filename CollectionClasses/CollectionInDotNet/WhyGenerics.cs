using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionInDotNet
{
    class WhyGenerics
    {
        static void Main(string[] args)
        {
            //ArrayList arr = new ArrayList();
            //arr.Add(22);
            //arr.Add(23);
            //arr.Add(21);
            //arr.Add("hi");

            //foreach (var item in arr)
            //{
            //    int res = (int)item;//unboxing
            //    Console.WriteLine();
            //}

            
            List<int> list = new List<int>();
            list.Add(22);
            list.Add(12);
            list.Add(33);
            Console.WriteLine("Element in List are:");
            foreach (int item in list)
            {
                
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("--------------------------------------------");
            int[] ar = new int[] { 2, 3, 4, 5 };
            list.AddRange(ar);
            Console.WriteLine("Element in List After Adding new Elements are:");
            foreach (int item in list)
            {

                Console.WriteLine(item);
            }
            //IEnumerator
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("List Element using IEnumerator");
            IEnumerator ie = list.GetEnumerator();
            while(ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }

            //Contains
            Console.WriteLine("-------------------Contains---------------------\n");
            Console.WriteLine($"Is list conatins value 4? {list.Contains(4)}");

            //GetRange
            Console.WriteLine("-------------------GetRange---------------------\n");
            var listArr = list.GetRange(1, 4);
            Console.WriteLine("Get Element in given Range");
            foreach (var range in listArr)
            {
                Console.WriteLine(range);
            }

            //InsertRange
            Console.WriteLine("-------------------GetIndex---------------------\n");
            var array1 = new int[] { 33,44,55,66,82,};
            list.InsertRange(5,array1);
            Console.WriteLine("Get Element in given Range");
            foreach (var range in list)
            {
                Console.WriteLine(range);
            }

            //list.Exists(item => item == 22);
            Console.WriteLine("-------------------Exists---------------------\n");
           
            Console.WriteLine($"Is the Element 5 exist in List? {list.Exists(item => item == 22) }\n");

            //Find
            Console.WriteLine("-------------------Find---------------\n");
            Console.Write("first occured element using Find Method is =");//starting its search from the first element and print first occured value
            var result = list.Find(element => element > 21);
            Console.WriteLine(result+"\n");


            //FindIndex
            Console.WriteLine("-------------------FindIndex---------------\n");
            Console.Write("first occured Index using FindIndex Method is =");
            var res = list.FindIndex(item=>item>21); //starting its search from the first element and print first occured Index
            Console.WriteLine(res+"\n");

            //FindLastIndex
            Console.WriteLine("-------------------FindLastIndex---------------\n");
            Console.Write("Last occured element using FindLastIndex Method is =");
            var resl = list.FindLastIndex(item => item > 21); //starting its search from the first element and print first occured Index
            Console.WriteLine(resl+"\n");


        }
    }
}
