using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class DetailDeposit
    {
        public int Id { get; set; }
        public int PriceUnit { get; set; }
        public int TotalUnit { get; set; }
        public DateTime? CompletedDateTime { get; set; }
        public Service Service { get; set; }
        public PrePaidPackage? PrePaidPackage { get; set; }
        public HeaderDeposit HeaderDeposit { get; set; }
    }
}
