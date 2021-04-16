using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
    }
}
