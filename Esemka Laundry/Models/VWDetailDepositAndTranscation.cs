using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class VWDetailDepositAndTranscation
    {
        [Key]
        public int Id { get; set; }
        public string PackageName { get; set; }
        public int? PackagePrice { get; set; }
        public int Quantity { get; set; }
        public int? EstimationDuration { get; set; }
        public int SubTotal { get; set; }
    }
}
