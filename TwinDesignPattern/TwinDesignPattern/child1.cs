using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinDesignPattern
{
    public class child1 : class1
    {
        public child2 child2 { get; set; }
        public void m3()
            => Console.WriteLine($"{nameof(child1)}.{nameof(child1.m3)} fonksiyonu.");
    }
}
