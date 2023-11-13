using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PublicTransportAPI.Models;

namespace PublicTransportAPI.Data
{
    public class PublicTransportAPIContext : DbContext
    {
        public PublicTransportAPIContext (DbContextOptions<PublicTransportAPIContext> options)
            : base(options)
        {
        }

        public DbSet<PublicTransportAPI.Models.Linha> Linha { get; set; } = default!;
    }
}
