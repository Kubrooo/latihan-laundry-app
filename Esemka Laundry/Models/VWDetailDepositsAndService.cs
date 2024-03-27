using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class VWDetailDepositsAndService
    {
        [Key]
        public int id { get; set; }
        public int HeaderDepositId { get; set; }
        public int PriceUnit { get; set; }
        public string? ServiceName { get; set; }
        public int? PrepaidPackageId { get; set; }
        public int? TotalUnit { get; set; }
        public DateTime? CompletedDateTime { get; set; }
    }
}
