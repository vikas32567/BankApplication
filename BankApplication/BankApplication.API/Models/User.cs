using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BankApplication.API.Models
{
    public class User
    {
        [Key]
        public long UserID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public long AccNoListID { get; set; }
        public string Password { get; set; }
        public long PhoneNo { get; set; }
        
    }
}
