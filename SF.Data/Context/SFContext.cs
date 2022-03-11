using Microsoft.EntityFrameworkCore;
using SF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Data.Context
{
    public class SFContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public SFContext(DbContextOptions options) : base(options)
        {

        }
    }
}
