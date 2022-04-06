using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinDesignPatternExample
{
    public interface IOperation
    {
        object Merge(object[] files);
        object SizeEnlargement(object file);
        object SizeReduction(object file);
        object Splitting(object file);
        object Convert(object file);
    }
}
