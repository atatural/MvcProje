using DataAccessLayer.Concrete.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    class PortfolioManager
    {
        GenericRepository<Portfolio> repo = new GenericRepository<Portfolio>();

        public List<Portfolio> GetAllBL()
        {
            return repo.List();
        }
        public void PortfolioAddBL(Portfolio p)
        {
            if (p.WorkName == "" || p.WorkName.Length <= 3 || p.WorkDescription == "" || p.WorkBackgroundImage=="" || p.WorkImage =="")
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
