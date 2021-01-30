using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CollectionInDotNet
{
    class GenericClass
    {
        static void Main(string[] args)
        {
            Person<String> st = new Person<string>();
            st.Name = "Amisha";
            Console.WriteLine("\nPerson detail is");
            st.DisplayName();
            Console.WriteLine("------------------EMPLOYEE-----------------------\n");

            Employee<int, string> ky = new Employee<int, string>();
            ky.salary = 23000;
            ky.eId = 111;
            ky.eDept = "Training Department";
            Console.WriteLine("Display EMployee Details");
            ky.DisplayDetails();

            Console.WriteLine("--------------------STUDENT------------------------\n");
            Student stud = new Student();
            Console.WriteLine("Student Details is");
            stud.StudentDetail<int, string>(17,"Rounak",20);


            Console.WriteLine("-------------------------Generic Array-----------------------------");
            GenericArray gen = new GenericArray();
            string[] arr = new string[]{ "Hello","Hey"};
            Console.WriteLine("Generic Array Elements using Array are:");
            gen.ArrayElements<string>(arr);//using array

            List<string> list= new List<string>();
            Console.WriteLine("Enter Elements to add in List");
            for (int i = 0; i < 5; i++)
            {
                list.Add(Console.ReadLine());
            }
            Console.WriteLine("Generic Array Elements are using List are:");
            gen.ArrayElements<string>(list);//using list

            //GenericConstraint<int> obj = new GenericConstraint<int>(); throw exception

            GenericConstraint<Student> obj = new GenericConstraint<Student>();

        }
    }

    //Generic class Defined using a type parameter in an angle brackets after class name
    //T is type name we can give any name to type parameter
    //its called generic bcoz its type is T instead of specific data type

    //T is type parameter it cant be used as a type of field,property,method,parameters,returntyep,delegates in DataStoreClass
    class Person<Tdata> 
    {
        public Tdata Name { get; set; }
        public void DisplayName()
        {
            Console.WriteLine($"Name of person is :{Name}\n");
        }
        

    }

    //can also contain multiple type parameters
    
    class Employee<TKey, TValue>
    {
        //can include generic field
        public TKey salary;
        public TKey eId { get; set; }
        public TValue eDept { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Id is : {eId}\nEmployee department is :{eDept}");
            Console.WriteLine($"Salary is :{salary}");
        }

    }

    class Student
    {

        //public void StudentDetail<TRoll, TName, TAge>(TRoll RollNo,TName Name,TAge Age)
        //{

        //    Console.WriteLine($"Student Roll No :{RollNo}\nStudnet Name :{Name}\nStudent Age :{Age}");
        //}
        public void StudentDetail<T , Ts>(T RollNo, Ts Name, T Age)
        {

            Console.WriteLine($"Student Roll No :{RollNo}\nStudnet Name :{Name}\nStudent Age :{Age}");
        }
    }

    class GenericArray
    {
        //public TArray[] arr = new TArray[5];
        public void ArrayElements<TArray>(IList<TArray> array) //with the IList we can iterate parameter through both list and array
        {
            
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


        }
    }

    class GenericConstraint<T> where T : class
    {

    }

    


}
