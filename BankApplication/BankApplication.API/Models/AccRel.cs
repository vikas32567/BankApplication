using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankApplication.API.Models
{
    public class AccRel
    {
        public long AccNoID { get; set; }
        [Key]
        public long AccNo { get; set; }
    }
}
