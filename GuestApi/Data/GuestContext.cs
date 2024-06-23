using Microsoft.EntityFrameworkCore;
using GuestApi.Models;
using System.Collections.Generic;

namespace GuestApi.Data
{
    public class GuestContext : DbContext
    {
        public GuestContext(DbContextOptions<GuestContext> options) : base(options) { }

        public DbSet<Guest> Guests { get; set; }
    }
}
