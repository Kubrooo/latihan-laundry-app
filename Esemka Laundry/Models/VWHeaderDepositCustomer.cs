using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemka_Laundry.Models
{
    public class VWHeaderDepositCustomer
    {
        [Key]
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string EmployeName { get; set; }
        public DateTime TransactionTime { get; set; }
        public DateTime? CompleteEstimationTime { get; set; }
    }
}
