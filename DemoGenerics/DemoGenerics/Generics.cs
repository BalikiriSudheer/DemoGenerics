using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    internal class Generics <T>
        
    {
        public T data;
        private int v;

        public Generics(T data)
        {
            this.data = data;
            Console.WriteLine(this.data);
        }

       
        public void DemoMethod(T no)
        {
            Console.WriteLine(no);
        }
    }
    public class Generic
    {
        public void GenericMethod<T>(T num)
        {
            Console.WriteLine(num);
        }
    }
}
