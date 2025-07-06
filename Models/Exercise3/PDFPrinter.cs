using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces._3;

namespace Classes._3
{
    public class PDFPrinter : IDigitalPrinter
    {
        public void PrintInvoice()
        {
            PrintToPDF();
        }

        public void PrintToPDF()
        {
            Console.WriteLine("→ Generating invoice PDF...");
        }
    }
}
