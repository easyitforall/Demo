using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InvoiceFactory
    {
        public static IInvoice GetInvoiceObject(string type)
        {
            IInvoice objInvoice = null;
            if (type == "purchase")
                objInvoice = new PurchaseInvoiced();
            else if (type == "sales")
                objInvoice = new SalesInvoice();

            return objInvoice;
        }
    }
}
