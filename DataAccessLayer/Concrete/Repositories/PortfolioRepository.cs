using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class PortfolioRepository : IPortfolioDal
    {
        Context c = new Context();
        DbSet<Portfolio> _object;

        public void Delete(Portfolio p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Portfolio p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Portfolio> List()
        {
            return _object.ToList();
        }

        public void Update(Portfolio p)
        {
            c.SaveChanges();
        }
    }
}
