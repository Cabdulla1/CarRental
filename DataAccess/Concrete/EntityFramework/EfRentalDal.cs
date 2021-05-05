using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDto> GetRentalDetails(Expression<Func<RentalDto, bool>> filter = null)
        {
            using (CarRentalContext context =new CarRentalContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.UserId
                             join ca in context.Cars
                             on r.CarId equals ca.Id
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new RentalDto
                             {
                                 Id = r.Id,
                                 CarId = ca.Id,
                                 CustomerId = c.UserId,
                                 BrandName = br.BrandName,
                                 Customer = u.FirstName+" "+u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate =r.ReturnDate
                             };



                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }    
        }
    }
}
