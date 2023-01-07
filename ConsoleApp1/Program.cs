using System;


namespace ConsoleApp1
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            IInvoice ObjInvoice = null;
            ObjInvoice=InvoiceFactory.GetInvoiceObject("purchase");
            Console.WriteLine(ObjInvoice.PrintInvoiceName());

        }

       

    }
   
}



