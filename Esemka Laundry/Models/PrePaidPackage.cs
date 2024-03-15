using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class PrePaidPackage
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime CompletedDateTime { get; set; }
        public Customer Customer { get; set; }
        public Package Package { get; set; }
    }
}
