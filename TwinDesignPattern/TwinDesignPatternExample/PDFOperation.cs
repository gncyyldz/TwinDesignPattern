using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinDesignPatternExample
{
    public class PDFOperation : IOperation
    {
        public object Convert(object file)
        {
            Console.WriteLine($"{nameof(PDFOperation)}.{nameof(PDFOperation.Convert)} fonksiyonu.");
            //... Convert operasyonu ...
            return file;
        }
        public object Merge(object[] files)
        {
            Console.WriteLine($"{nameof(PDFOperation)}.{nameof(PDFOperation.Merge)} fonksiyonu.");
            //... Merge operasyonu ...
            return files;
        }
        public object SizeEnlargement(object file)
        {
            Console.WriteLine($"{nameof(PDFOperation)}.{nameof(PDFOperation.SizeEnlargement)} fonksiyonu.");
            //... SizeEnlargement operasyonu ...
            return file;
        }
        public object SizeReduction(object file)
        {
            Console.WriteLine($"{nameof(PDFOperation)}.{nameof(PDFOperation.SizeReduction)} fonksiyonu.");
            //... SizeReduction operasyonu ...
            return file;
        }
        public object Splitting(object file)
        {
            Console.WriteLine($"{nameof(PDFOperation)}.{nameof(PDFOperation.Splitting)} fonksiyonu.");
            //... Splitting operasyonu ...
            return file;
        }
    }
}
