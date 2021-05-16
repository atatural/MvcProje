using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    class Context: DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
