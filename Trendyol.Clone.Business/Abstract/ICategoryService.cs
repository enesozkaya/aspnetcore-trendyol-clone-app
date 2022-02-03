using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Clone.Entities.Concrete;

namespace Trendyol.Clone.Bussiness.Abstract
{
    public interface ICategoryService
    {
        void Add(Category entity);
        void Delete(Category entity);
        void Update(Category entity);
        List<Category> GetList();
    }
}

