using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentalDto> GetRentalDetails(Expression<Func<RentalDto, bool>> filter = null);
    }
}
