using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInDotNet
{
    class GenericSeqCollection
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[] { 2,3,7,6,17,4,5,17});
            Console.WriteLine("Elements of list :");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Find
            Console.WriteLine("-------------------Find---------------\n");
            Console.Write("first occured element using Find Method is =");//starting its search from the first element and print first occured value
            var result = list.Find(element => element ==6);
            Console.WriteLine(result + "\n");

            //FindAll
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("All even element from list is ");
            List<int> ls = list.FindAll(x => x % 2 == 0);
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }

            //FindIndex
            Console.WriteLine("-------------------FindIndex---------------\n");
            Console.Write($"first occured Index using FindIndex Method is = {list.FindIndex(item => item == 17)}\n");//starting its search from the first element and print first occured Index


            //FindLastIndex
            Console.WriteLine("-------------------FindLastIndex---------------\n");
            Console.Write($"Last occured element using FindLastIndex Method is ={list.FindLastIndex(item => item == 17)}\n");//starting its search from the first element and print first occured Index

            //Aggregate
            Console.WriteLine("-------------------Aggregate---------------\n");
            Console.WriteLine($"Adding list elements : {list.Aggregate((x, y) => x + y)}");

            //All
            Console.WriteLine("-------------------All---------------\n");
            Console.WriteLine($"ALl are Even number??: {list.All(x=> x%2==0)}");

            Console.WriteLine("-------------------Any---------------\n");
            Console.WriteLine($"Some are Even Number??: {list.Any(x => x % 2 == 0)}");

            Console.WriteLine("-------------------Count---------------\n");
            Console.WriteLine($"Count of  Even Number??: {list.Count(x => x % 2 == 0)}");

            Console.WriteLine("-------------------Average---------------\n");
            Console.WriteLine($"Average of number??: {list.Average()}");


            Console.WriteLine("-------------------Concat---------------\n");
            Console.WriteLine("Concate the list");
            List<int> list2 = new List<int>(new int[] { 22, 44, 55 });
            IEnumerable<int> res= list.Concat(list2);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------AEnumerable---------------\n");
            Console.WriteLine("Elements of array using AsEnumerable");
            IEnumerable<int> ee= list.AsEnumerable();
            foreach (var item in ee)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("-------------------Append---------------\n");
            var lsttt= list.Append(44);
            Console.WriteLine("After APpend value elements are:");
            foreach (var item in lsttt)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Casting element");
            IEnumerable<double> cst=list.Cast<double>();
            Console.WriteLine(cst.GetType());

            Stack<string> str = new Stack<string>();
            Queue<string> str1 = new Queue<string>();
        }
    }
}
