using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.DataAccess.Data.Repositories.IRepositories
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Category { get; }
        void Save();
    }
}
