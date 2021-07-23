using Business.Concrete;
using Core.Entities.Concrete;
using DataAcces.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //CarGetByDailyPriceTest(carManager);


            //UserManager userManager = new UserManager(new EfUserDal());

            //userManager.Add(new User { FirstName = "Akif", LastName = "Yigit", Email = "ayigit@gmail.com", Password = "Akif1111" });

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //foreach (var customer in customerManager.GetAll().Data)
            //{
            //    Console.WriteLine(customer.CompanyName);
            //}

            //GetCarDetailsTest(carManager);

            //CarDeleteTest(carManager);
            //CarUpdateTest(carManager);

            ColorManager colorManager = new ColorManager(new EfColorDal());

            //ColorGetAllTest(colorManager);
            //ColorAddTest(colorManager);
            //ColorDeleteTest(colorManager);
            //ColorUpdateTest(colorManager);

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //BrandGetAllTest(brandManager);
            //BrandAddTest(brandManager);
            //brandManager.Delete(new Brand { Id=4});
            //BrandUpdateTest(brandManager);


            //UserManager userManager = new UserManager(new EfUserDal());

            //var result = userManager.GetAll().Data;

            //foreach (var user in result)
            //{
            //    Console.WriteLine(user.FirstName);
            //}


            //CarRentalContext carRentalContext = new CarRentalContext();

            //UserManager userManager = new UserManager(new EfUserDal());

            //var result = userManager.GetById(1);
            //Console.WriteLine(result.Data.PasswordHash.ToString());

            string date = "04/21/2021";
            //string date2 = String.Format("{0:MM-dd-yyyy}", date);
            //DateTime dt = DateTime.Parse(date2);

            //DateTime dt = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            //Console.WriteLine(dt.ToString());


            //Console.WriteLine(date);
            //string date1;

            //char[] date3 = date.ToCharArray();
            //char temp;

            //temp = date3[0];
            //date3[0] = date3[3];
            //date3[3] = temp;

            //temp = date3[1];
            //date3[1] = date3[4];
            //date3[4] = temp;

            //date1 = new string(date3);
            //Console.WriteLine(date1);



            //RentalManager r = new RentalManager(new EfRentalDal());

            //Rental rental = new Rental { RentDate = Convert.ToDateTime("10/05/2021") };
            //var result = r.GetByDate("13/05/2021");

            //if (result.Data != null)
            //{
            //    Console.WriteLine("Arac bu tarihte zaten kiralanmis");
            //}


            UserManager userManager = new UserManager(new EfUserDal());

            string email = "cavidan2@gmail.com";
            var result = userManager.GetByMail(email);
            Console.WriteLine(result.Data.FirstName);



        }

        private static void CarGetByDailyPriceTest(CarManager carManager)
        {
            var result = carManager.GetByDailyPrice(0, 500);

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
        }

        private static void BrandUpdateTest(BrandManager brandManager)
        {
            brandManager.Update(new Brand { Id = 5, BrandName = "Peugoet" });
        }

        private static void BrandAddTest(BrandManager brandManager)
        {
            brandManager.Add(new Brand { BrandName = "Renault" });
        }

        private static void BrandGetAllTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorUpdateTest(ColorManager colorManager)
        {
            colorManager.Update(new Color { Id = 3, ColorName = "Gold" });
        }

        private static void ColorDeleteTest(ColorManager colorManager)
        {
            colorManager.Delete(new Color { Id = 4 });
        }

        private static void ColorAddTest(ColorManager colorManager)
        {
            colorManager.Add(new Color { ColorName = "Yellow" });
        }

        private static void ColorGetAllTest(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarUpdateTest(CarManager carManager)
        {
            carManager.Update(new Car { Id = 3, CarName = "i8", BrandId = 2, ColorId = 1, DailyPrice = 380, ModelYear = "2017", Description = "ikinci el" });
        }

        private static void CarDeleteTest(CarManager carManager)
        {
            carManager.Delete(new Car { Id = 2 });
        }

        private static void CarAddTest(CarManager carManager)
        {
            carManager.Add(new Car { CarName = "Insignie", BrandId = 3, ColorId = 2, ModelYear = "2016", DailyPrice = 200, Description = "ikinci el" });
        }

        private static void GetCarDetailsTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} / {1} / {2} / {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }
    }
}
