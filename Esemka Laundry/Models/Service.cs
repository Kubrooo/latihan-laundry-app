using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PriceUnit { get; set; }
        public int EstimationDuration { get; set; }

        public Category Category { get; set; }
        public Unit Unit { get; set; }
    }
}
