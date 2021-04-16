using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalContext>, IUserDal
    {
        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            using (CarRentalContext context =new CarRentalContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id,Name = operationClaim.Name};

                return new SuccessDataResult<List<OperationClaim>>(result.ToList());
              
            }
        }
    }
}
