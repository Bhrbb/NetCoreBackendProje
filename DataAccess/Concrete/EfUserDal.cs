
using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWrok.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfUserDal : EfEntitiyRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
           using(var context=new NorthwindContext() )
            {
                var result=from operationclaim in context.operationClaims
                           join UserOperationClaim in context.userOperationClaims
                           on operationclaim.Id equals UserOperationClaim.OperationClaimId
                           where UserOperationClaim.UserId==user.Id
                           select new OperationClaim { Id=operationclaim.Id,Name=operationclaim.Name };
                return result.ToList();

            }
        }
    }
}
