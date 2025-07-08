using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MVC
{
    public class Loan
    {
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime LoanDate { get; set; } = DateTime.Now;

        public Loan() { }

    }
}
