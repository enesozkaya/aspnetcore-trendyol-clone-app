using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolClone.Business.Abstract;
using TrendyolClone.Business.Contants;
using TrendyolClone.Entities.Concrete;
using TrendyolCloneDataAccess.Abstract;

namespace TrendyolClone.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        
        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId == categoryId));
        }

        public IDataResult<List<Category>> GetList()
        {
            try
            {
                Convert.ToInt32("enes");
                return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Category>>(null,Messages.CategoryAdded);
            }
            
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }
    }
}
