using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Clone.Bussiness.Abstract;
using Trendyol.Clone.DataAccess.Data;
using Trendyol.Clone.Entities.Concrete;

namespace Trendyol.Clone.Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private DataContext _context;

        public CategoryManager(DataContext context)
        {
            _context = context;
        }
        public void Add(Category entity)
        {
            _context.Category.Add(entity);
            
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
