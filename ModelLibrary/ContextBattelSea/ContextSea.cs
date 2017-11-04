using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.ContextBattelSea
{
    public  class ContextSea:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<BattelField> Fields { get; set; }

        public ContextSea(): base("SeaBattleConnection"){ }

        public ContextSea(string connectionStringOrName): base(connectionStringOrName){}
    }
}
