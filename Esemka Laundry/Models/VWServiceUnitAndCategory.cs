using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class VWServiceUnitAndCategory
    {
        [Key]
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string Category { get; set; }
        public string Unit {  get; set; }
        public int Price { get; set; }
        public int EstimationDuration { get; set; }

    }
}
