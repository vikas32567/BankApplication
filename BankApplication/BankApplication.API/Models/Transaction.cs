using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankApplication.API.Models
{
    public class Transaction
    {
        [Key]
        public long TransactionID { get; set; }
        public long SenderAcc { get; set; }
        public long ReceiverAcc { get; set; }
        public long Amount { get; set; }
        public DateTime XferTime { get; set; }
    }
}
