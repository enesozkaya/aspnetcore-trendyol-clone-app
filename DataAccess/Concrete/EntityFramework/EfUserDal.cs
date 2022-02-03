using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolClone.Core.DataAccess.EntityFremawork;
using TrendyolClone.Core.Entity.Concrete;
using TrendyolCloneDataAccess.Abstract;
using TrendyolCloneDataAccess.Concrete.EntityFramework.Context;

namespace TrendyolCloneDataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, TrendyolCloneContext>, IUserDal
    {
        public List<OperationClaim> GetClaim (User user)
        {
            using (var context = new TrendyolCloneContext())
            {
                var result = from OperationClaim in context.OperationClaims
                             join UserOperationClaim in context.UserOperationClaims
                             on OperationClaim.Id equals UserOperationClaim.OperationClaimId
                             where UserOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = OperationClaim.Id, Name = OperationClaim.Name };
                return result.ToList();
            }
        }
    }
}
