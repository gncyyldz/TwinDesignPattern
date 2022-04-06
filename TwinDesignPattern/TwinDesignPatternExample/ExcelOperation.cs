using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinDesignPatternExample
{
    public class ExcelOperation : IOperation
    {
        public object Convert(object file)
        {
            Console.WriteLine($"{nameof(ExcelOperation)}.{nameof(ExcelOperation.Convert)} fonksiyonu.");
            //... Convert operasyonu ...
            return file;
        }
        public object Merge(object[] files)
        {
            Console.WriteLine($"{nameof(ExcelOperation)}.{nameof(ExcelOperation.Merge)} fonksiyonu.");
            //... Merge operasyonu ...
            return files;
        }
        public object SizeEnlargement(object file)
        {
            Console.WriteLine($"{nameof(ExcelOperation)}.{nameof(ExcelOperation.SizeEnlargement)} fonksiyonu.");
            //... SizeEnlargement operasyonu ...
            return file;
        }
        public object SizeReduction(object file)
        {
            Console.WriteLine($"{nameof(ExcelOperation)}.{nameof(ExcelOperation.SizeReduction)} fonksiyonu.");
            //... SizeReduction operasyonu ...
            return file;
        }
        public object Splitting(object file)
        {
            Console.WriteLine($"{nameof(ExcelOperation)}.{nameof(ExcelOperation.Splitting)} fonksiyonu.");
            //... Splitting operasyonu ...
            return file;
        }
    }
}
