using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinDesignPattern
{
    public class class1
    {
        public void m1()
            => Console.WriteLine($"{nameof(class1)}.{nameof(class1.m1)} fonksiyonu.");
    }
}
