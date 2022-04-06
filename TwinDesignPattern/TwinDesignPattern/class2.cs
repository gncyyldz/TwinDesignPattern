using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinDesignPattern
{
    public class class2
    {
        public void m2()
            => Console.WriteLine($"{nameof(class2)}.{nameof(class2.m2)} fonksiyonu.");
    }
}
