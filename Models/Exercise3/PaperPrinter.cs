using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces._3;

namespace Classes._3
{
    public class PaperPrinter : IPaperPrinter
    {
        public void PrintInvoice()
        {
            PrintOnPaper();
        }

        public void PrintOnPaper()
        {
            Console.WriteLine("→ Printing invoice on paper...");
        }
    }
}
