using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PurchaseInvoiced:IInvoice
    {
        public string PrintInvoiceName()
        {
            return "This is purchase invoice";
        }
    }
}
