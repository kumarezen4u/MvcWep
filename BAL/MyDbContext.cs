using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMvc.BAL
{
    public class MyDbContext: DbContext 
    {
        public DbSet<Products> products { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Users> users { get; set; }
       
    }
}