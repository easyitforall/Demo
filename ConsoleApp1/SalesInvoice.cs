using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SalesInvoice:IInvoice
    {
        public string PrintInvoiceName()
        {
            return "This is sales invoice";
        }
    }
}
