using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionInDotNet
{
    class DictionaryGenColl
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary 1 key values");
            Dictionary<string, int> di = new Dictionary<string, int>();
            di.Add("one", 1);
            di.Add("two", 2);
            di.Add("three", 3);
            di.Add("four", 4);
            di.Add("five", 5);
            foreach (KeyValuePair<string,int> item in di)
            {
                //Console.WriteLine($"key = {item.Key} & value = {item.Value}");
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------retrieve data---------------------------------\n");
            Console.WriteLine("Dictionary 2 key values");
            Dictionary<int, int> id = new Dictionary<int, int>();
            id[1] = 2;
            id[2] = 21;
            id[3] = 22;
            id[4] = 23;

            foreach (var item in id)
            {
                Console.WriteLine(item.Key+"="+item.Value);
            }
            Console.WriteLine("------------------------All---------------------------------\n");
            Console.WriteLine($"IS THere any Key greater than 2? {id.All(x => x.Key > 2)}\n");
            Console.WriteLine("------------------------Any---------------------------------\n");
            Console.WriteLine($"Is there any Value greater than 3? {id.Any(x => x.Value > 3)}\n");

        }
    }
}
