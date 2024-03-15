using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class HeaderDeposit
    {
        public int Id { get; set; }
        public DateTime TransactionDateT { get; set; }
        public DateTime CompleteEstimatedDateTime { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
    }
}
