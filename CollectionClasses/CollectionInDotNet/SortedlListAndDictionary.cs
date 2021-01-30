using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace CollectionInDotNet
{
    class SortedlListAndDictionary
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sortDic = new SortedDictionary<int, string>();
            Console.WriteLine("Dictionary Data is ");
            sortDic.Add(1, "Bhopal");
            sortDic.Add(2, "Indore");
            sortDic.Add(3, "Mumbai");
            foreach (KeyValuePair<int,string> item in sortDic)
            {
                Console.WriteLine(item.Key+" = "+item.Value);
            }

            Console.WriteLine("--------------------------ContainsKey---------------------\n");
            Console.WriteLine($"IS Dictionary conatins key 2 {sortDic.ContainsKey(2)}\n");

            Console.WriteLine("--------------------------ContainsValue---------------------\n");
            Console.WriteLine($"IS Dictionary conatins key 2 {sortDic.ContainsValue("Dhar")}\n");


            SortedDictionary<int, string> sortDic1 = new SortedDictionary<int, string>();
            sortDic1.Add(1, "Bhopal");
            sortDic1.Add(2, "Indore");
            sortDic1.Add(3, "Mumbai");
            sortDic.Add(4, "gujrat");

            SortedDictionary<int, string> sortDic2 = new SortedDictionary<int, string>();
            sortDic2 = sortDic1;
            Console.WriteLine("--------------------------Equals---------------------\n");
            Console.WriteLine($"IS both Dictionary are Equal ? {sortDic.Equals(sortDic1)}\n");
            Console.WriteLine($"IS Dictionary 1 and 2 are Equal ? {sortDic1.Equals(sortDic2)}\n");

            Console.WriteLine("--------------------------GetHashCode---------------------\n");
            Console.WriteLine($"HashCode of sortDic object is : {sortDic.GetHashCode()}");

            Console.WriteLine("--------------------------Remove---------------------\n");
            Console.WriteLine($"HashCode of sortDic object is : {sortDic.Remove(3)}");
            foreach (KeyValuePair<int, string> item in sortDic)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }

            Console.WriteLine("\n-------------------------------SortedList-----------------------------------------\n");

            //SortedList collection
            SortedList<int, string> std = new SortedList<int, string>();
            std.Add(1, "Mon");
            std.Add(2, "tue");
            std.Add(3, "wed");
            std.Add(4, "thru");
            std.Add(5, "fri");
            std.Add(6, "sat");

            Console.WriteLine("SortedList elements are:");
            foreach (KeyValuePair<int,string> item in std)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }

            Console.WriteLine("--------------------------Count---------------------\n");
            Console.WriteLine($"Count of sortedList : {std.Count}");

            //ContainsValue
            Console.WriteLine("-------------------------ContainsKey---------------------------");
            Console.WriteLine($"Is generic SortedList Contains Key 9 ? {std.ContainsKey(9)}\n");

            //ContainsValue
            Console.WriteLine("-------------------------ContainsValue---------------------------");
            Console.WriteLine($"Is generic SortedList Contains Values \"Fri\" ? {std.ContainsValue("Fri")}\n");

            //IndexOfKey
            Console.WriteLine("-------------------------IndexOfKey---------------------------\n");
            Console.WriteLine($"Index of key 6 is = {std.IndexOfKey(6)}\n"); //wrong key gives restu in -1

            //IndexOfValue
            Console.WriteLine("-------------------------IndexOfValue---------------------------");
            Console.WriteLine($"Index of VAlue fri is = {std.IndexOfValue("fri")}\n");

            //Remove
            Console.WriteLine("-------------------------Remove---------------------------\n");
            std.Remove(4);
            Console.WriteLine("after removing value of key 4 :");
            foreach (KeyValuePair<int,string> d in std)
            {
                Console.WriteLine($"key = {d.Key} & Value = {d.Value}");
            }

            //Clear
            Console.WriteLine("-------------------------Clear---------------------------\n");
            Console.WriteLine("Clearing the data of sortedList:");
            std.Clear();
            foreach (var item in std)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------Count---------------------\n");
            Console.WriteLine($"Count of sortedList : {std.Count}");



        }
    }
}
