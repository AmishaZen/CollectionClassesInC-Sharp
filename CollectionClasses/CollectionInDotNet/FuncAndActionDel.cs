using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInDotNet
{
    delegate int Calc(int x, int y);
    class FuncAndActionDel
    {
        public static int Add(int x , int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Calc delcl = new Calc(Add);
            Console.WriteLine($"Addition of two is {delcl(10,20)}");

            //the above delegate code can  be written using the concept of anonymous method
            Calc delcl1 = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine($"Addition of two using anonymous method {delcl1(10, 20)}");


            //in version 3.0 lambda were intiducted to implement methods
            Calc del2= (x,y) => x + y; //introduced in 3.0 is denoated as lambda and read as goes to return
            Console.WriteLine($"Addition of two using lambda {del2(10, 20)}");

            //Func And Action builtin Delegate
            //we can use Func delegate if and only if method which the func delegate is executing a valid c# return type
            Func<int, int, int> del3 = (x, y) => x + y;
            Console.WriteLine($"Addition of two using Func {del3(10, 20)}");

            //we can use action delegate which will be exceuted through void c# return type
            Action res = () => Console.WriteLine("Using Action delegate");
        }
    }
}
