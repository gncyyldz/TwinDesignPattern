using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinDesignPattern
{
    public class child2 : class2
    {
        public child1 child1 { get; set; }
        public void m4()
         => Console.WriteLine($"{nameof(child2)}.{nameof(child2.m4)} fonksiyonu.");
    }
}
