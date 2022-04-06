using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinDesignPatternExample
{
    public class ChildPDFOperation : PDFOperation
    {
        public ChildExcelOperation Excel { get; set; }
        public bool SendMail(object file)
        {
            //... SendMail operasyonu ....
            return true;
        }
    }
}
