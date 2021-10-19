using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SimpleRegistrationPage.Models
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SimpleRegistratorPageLibrary.Model.Account> Accounts { get; set; }
        public DbSet<Account> AccountsFrontEnd { get; set; }
    }
}
