using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine($"Initial Capacity :{arr.Capacity}");
            foreach(var v in arr)
            {
                Console.WriteLine(v);
            }
            arr.Add(10);
            Console.WriteLine($"Initial Capacity :{arr.Capacity}");

            var name = new string[] { "AMisha","rithika","Deeptesh","AMan"};
            ArrayList arl = new ArrayList(name);

            IList il = new ArrayList();
            ICollection ic = new ArrayList();

            var array1 = new ArrayList();
            array1.Add(12);
            array1.AddRange(name);
            array1.AddRange(new int[] { 2, 3, 4, 5,6,3,8 });
            foreach (var va in array1)
            {
                Console.WriteLine(va);
            }

            Console.WriteLine($"Value 2 is Present {array1.Contains(2)}");
            array1.Remove(3);
            Console.WriteLine($"after removing");
            foreach (var va in array1)
            {
                Console.WriteLine(va);
            }

            //Insert
            Console.WriteLine("--------------------------------");
            Console.WriteLine("After Inserting value");
            array1.Insert(3,"Sai");
            foreach (var ins in array1)
            {
                Console.WriteLine(ins);
            }

            //InsertRange
            Console.WriteLine("--------------------------------");
            Console.WriteLine("After Inserting value in RAnge");
            array1.InsertRange(6,name);
            foreach (var res in array1)
            {
                Console.WriteLine(res);
            }
            // Count
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Count of array is {array1.Count}");


            //copyTo
            Console.WriteLine("--------------------------------");
            Console.WriteLine("CopyTo");
            var array2 = new String[15];
            array1.CopyTo(1, array2, 1, 4);
            foreach (var ins in array2)
            {
                Console.WriteLine(ins);
            }

            //GetEnumerator
            Console.WriteLine("GetEnuerator result");
            IEnumerator ie = array1.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }

            //getRange
            Console.WriteLine("--------------------------------");
            var array3 = array1.GetRange(0, 4);
            Console.WriteLine("Get RAnge");

            foreach (var range in array3)
            {
                Console.WriteLine(range);
            }

            //IndexAt
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("");
            
            Console.WriteLine($"indexof rithika is {array1.IndexOf("rithika")}");
            foreach (var ins in array2)
            {
                Console.WriteLine(ins);
            }

            //Remove Range
            Console.WriteLine("-----------------------------------");
            array1.RemoveRange(0, 2);
            Console.WriteLine("After REmoving values");
            foreach (var res in array1)
            {
                Console.WriteLine(res);
            }
            Console.WriteLine("--------------------------------------------");
            var sortarr = new ArrayList(new string[] {"Deeptesh","ekta","abhay","Sai" });
            Console.WriteLine("Array list before sorting");
            foreach (var res in sortarr)
            {
                Console.WriteLine(res);
            }
            sortarr.Sort();
            Console.WriteLine("Array list after sorting");
            foreach (var res in sortarr)
            {
                Console.WriteLine(res);
            }
        }
    }
}
