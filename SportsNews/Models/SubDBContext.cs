using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SportsNews.Models
{
    public class SubDBContext : DbContext
    {
        public SubDBContext() : base("DefaultConnection")
        {
          Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subscriptions> Sub { get; set; }
    }
}