using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class VWServiceAndPackage
    {
        [Key]
        public int PackageID { get; set; }
        public string ServiceName { get; set; }
        public int TotalUnit { get; set; }
        public int Price { get; set; }
    }
}
