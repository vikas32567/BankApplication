using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankApplication.API.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccID { get; set; }
        public int AccNo { get; set; }
        public int Bal { get; set; }
        public string AccType { get; set; }

    }
    //Savings, BasicChecking, InterestBearingChecking, MoneyMarketDeposit, TimeDeposits
}
