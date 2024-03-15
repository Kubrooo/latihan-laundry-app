using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class Package
    {
        public int Id { get; set; }
        public int TotalUnit { get; set; }
        public int Price { get; set; }
        public Service Service { get; set; }
    }
}
