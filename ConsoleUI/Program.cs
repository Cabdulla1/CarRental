using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //CarGetByDailyPriceTest(carManager);


            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Add(new User { FirstName = "Akif", LastName = "Yigit", Email = "ayigit@gmail.com", Password = "Akif1111" });



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
