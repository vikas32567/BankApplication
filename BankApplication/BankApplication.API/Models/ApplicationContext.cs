using Microsoft.EntityFrameworkCore;

namespace BankApplication.API.Models
{
    public class BankApplicationContext : DbContext
    {
        public BankApplicationContext(DbContextOptions<BankApplicationContext> opts) : base(opts)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<AccRel> AccRel { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}
    }
}