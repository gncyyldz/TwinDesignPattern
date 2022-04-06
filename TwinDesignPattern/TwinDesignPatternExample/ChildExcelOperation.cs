using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinDesignPatternExample
{
    public class ChildExcelOperation : ExcelOperation
    {
        public ChildPDFOperation PDF { get; set; }
    }
}
