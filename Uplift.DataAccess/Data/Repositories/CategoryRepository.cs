using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uplift.DataAccess.Data.Repositories.IRepositories;
using Uplift.Models;
using Uplift.Web.DataAccess.Data;

namespace Uplift.DataAccess.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public CategoryRepository(ApplicationDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<SelectListItem> GetCategoryListForDropdown()
        {
            var selectListItemList = _appDbContext.Categories.Select(a => new SelectListItem
            {
                Text = a.Name,
                Value = a.Id.ToString()
            });
            return selectListItemList;
        }

        public void Update(int id, Category entity)
        {
            var categoryInDb = _appDbContext.Categories.Where(a => a.Id == id).FirstOrDefault();
            categoryInDb.Name = entity.Name;
            categoryInDb.DisplayOrder = entity.DisplayOrder;

        }
    }
}
