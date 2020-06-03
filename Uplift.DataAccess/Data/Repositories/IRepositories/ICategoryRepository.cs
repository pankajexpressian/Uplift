using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repositories.IRepositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropdown();
        void Update(int id, Category entity);
    }
}
