using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInDotNet
{
    public class Person
    {
        public int  Age{ get; set; }
        public string Name { get; set; }

        public string City{ get; set; }

        public Person()
        {

        }

        public Person(int age,string name,string city)
        {
            Age = age;
            Name = name;
            City = city;
        }

        public void Show()
        {
            Console.WriteLine("Person details");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Name : {Name}\nAge : {Age}\nCity : {City}");
        }
    }
    class GenListPersonEg
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person(22,"Amisha","indore"));
            var persons = new Person[] {new Person(23,"rithika","Hyderabad"),
                                         new Person(21,"ekta","indore"),
                                         new Person(23,"sai","bhopal"),
                                         new Person(22,"deeptesh","mumbai"),
                                      };
            people.AddRange(persons);
            foreach (var item in people)
            {
                item.Show();
               
            }

        }
    }
}
