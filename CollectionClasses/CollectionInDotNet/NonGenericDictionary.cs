using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionInDotNet
{
    class NonGenericDictionary
    {
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();
            hs.Add("100", "Jan");
            hs.Add("102", "Feb");
            hs.Add("103", "mar");
            hs.Add("104", "apr");
            hs.Add("105", null);
            //hs.Add("104", "apr");// it throw exception bcoz of dublipcate key

            //foreach (var item in hs)
            //{
            //    Console.WriteLine(hs.Keys+" "+hs.Values);
            //}
            foreach (DictionaryEntry d in hs)
            {
                Console.WriteLine($"Key is {d.Key} value is {d.Value}");
            }
            Console.WriteLine($"Contains int value 100 {hs.Contains(102)}");
            Console.WriteLine($"Contains int value 100 {hs.ContainsValue("Jan")}");
            Console.WriteLine($"Contains int value 100 {hs.ContainsKey("102")}");
            Console.WriteLine("ALl Keys are");
            ICollection ic = hs.Keys;
            foreach (var item in ic)
            {
                Console.WriteLine(item);
            }

            //values
            Console.WriteLine("---------------------------");
            Console.WriteLine("All Values from Table");
            ICollection i = hs.Values;
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }

            //count
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Count of hashTable {hs.Count}");

            //remove
            Console.WriteLine("---------------------------");
            Console.WriteLine("Remove value from table");
            hs.Remove(100);
            foreach (DictionaryEntry d in hs)
            {
                Console.WriteLine($"Key is {d.Key} value is {d.Value}");
            }
            //Contains Value
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Containsvalue Feb? {hs.ContainsValue("Feb")}");


            //GetEnumerator
            Console.WriteLine("--------------------------");
            Console.WriteLine("Using getEnumerator");
            IDictionaryEnumerator e = hs.GetEnumerator();
            while(e.MoveNext())
            {
                Console.WriteLine($"Key is {e.Key} value is {e.Value}");
            }
            //count
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Count of hashTable {hs.Count}");

            //CopyTo
            var array = new DictionaryEntry[hs.Count];
            hs.CopyTo(array, 0);
            Console.WriteLine("CopyTo array");
            foreach (var item in array)
            {
                Console.WriteLine(item.Key+"=="+item.Value);
            }


            //Hashtable Indexer
            Console.WriteLine("---------------------------------------");
            var newHash = new Hashtable();
            newHash[1] = "one";
            newHash[2] = "two";
            newHash[3] = "three";
            newHash[3] = "four";
            newHash[4] = "four";
            foreach (DictionaryEntry d in newHash)
            {
                Console.WriteLine($"Key is {d.Key} value is {d.Value}");
            }
        }
    }
}
