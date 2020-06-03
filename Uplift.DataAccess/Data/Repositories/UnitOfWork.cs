using System;
using System.Collections.Generic;
using System.Text;
using Uplift.DataAccess.Data.Repositories.IRepositories;
using Uplift.Web.DataAccess.Data;

namespace Uplift.DataAccess.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _appDbContext;
        public UnitOfWork(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            Category = new CategoryRepository(_appDbContext);
        }

        public ICategoryRepository Category { get; private set; }

        public void Dispose()
        {
            if (_appDbContext != null)
                _appDbContext.Dispose();
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }
    }
}
