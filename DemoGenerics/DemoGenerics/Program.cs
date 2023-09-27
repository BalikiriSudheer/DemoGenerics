using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generics<int> generics = new Generics<int>(10);
            Generics<string> genericsString = new Generics<string>("sudheer");
            Console.WriteLine();

            generics.DemoMethod(999);
            genericsString.DemoMethod("Sudher");
            Console.WriteLine();

            Generic generic= new Generic();
            generic.GenericMethod(5);
            generic.GenericMethod("sudheer");
            generic.GenericMethod<int>(5);
            generic.GenericMethod<string>("sudheer");
            Console.ReadLine();
        }
    }

}
