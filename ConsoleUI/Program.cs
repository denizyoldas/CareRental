using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //CarCreate(carManager);
            carList(carManager);
        }

        private static void carList(CarManager carManager)
        {
            var carList = carManager.GetCarDetails();
            foreach (var car in carList.Data)
            {
                Console.WriteLine("{0} - {1}",car.BrandName, car.ColorName);
            }
        }

        private static void CarCreate(CarManager carManager)
        {
            Car car = new Car();
            car.BrandId = 1;
            car.ColorId = 1;
            car.DailyPrice = 250000;
            car.Description = "Very fast car";
            car.ModelYear = DateTime.Now;

            carManager.Add(car);
        }
    }
}
