using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from ca in context.Cars
                             join b in context.Brands
                             on ca.BrandId equals b.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             select new CarDetailDto 
                             { 
                                 CarName=ca.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice

                             };

                return result.ToList();              
            }
        }
    }
}
