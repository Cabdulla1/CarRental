using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfBrandDal :EfEntityRepositoryBase<Brand,CarRentalContext>,IBrandDal
    {

    }
}
