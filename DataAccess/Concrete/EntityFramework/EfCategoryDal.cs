using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolClone.Core.DataAccess.EntityFremawork;
using TrendyolClone.Entities.Concrete;
using TrendyolCloneDataAccess.Abstract;
using TrendyolCloneDataAccess.Concrete.EntityFramework.Context;

namespace TrendyolCloneDataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, TrendyolCloneContext>, ICategoryDal
    {
    }
}
