using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class VWPrepaidPackageCustomerAndService
    {
        public int Id{ get; set; }
        public string Name { get; set; }

        public string PackageName { get; set; }
        public int Price { get; set; }
    }
}
