using Core.DataAccess.EntityFramework;
using DataAcces.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPaymentDal: EfEntityRepositoryBase<Payment, CarRentalContext>,IPaymentDal
    {

    }
}
