using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolClone.Core.DataAccess;
using TrendyolClone.Core.Entity.Concrete;

namespace TrendyolCloneDataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaim(User user);
    }
}
