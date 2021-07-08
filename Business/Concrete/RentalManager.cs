using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Business.Constants;
using Core.Business;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }


        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {

            if (BusinessRules.Run(CheckCarAvailable(rental)) != null)
            {
                return new ErrorResult(Messages.CarAlreadyRented);
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarRented);
            }

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId));
        }

        public IDataResult<List<RentalDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IResult CheckCarAvailable(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate >= rental.RentDate).Count;
            if (result>=1)
            {
                return new ErrorResult();
            }

            return new SuccessResult();
        }

        public IDataResult<List<RentalDto>> GetRentalDetailsById(int rentalId)
        {
            return new SuccessDataResult<List<RentalDto>>(_rentalDal.GetRentalDetails(r => r.Id == rentalId));
        }
    }
}
