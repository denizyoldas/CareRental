using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<Car> GetCarsByBrandId(int brandId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Cars.Where(c => c.BrandId == brandId).ToList();
            }
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Cars.Where(c => c.ColorId == colorId).ToList();
            }
        }

        public List<CarDetailDto> GetProductDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = (from c in context.Cars
                              join b in context.Brands on c.BrandId equals b.Id
                              join co in context.Colors on c.ColorId equals co.Id
                              select new CarDetailDto
                              {
                                  CarId = c.Id,
                                  BrandName = b.Name,
                                  ColorName = co.Name,
                                  DailyPrice = c.DailyPrice,
                                  Description = c.Description,
                                  ModelYear = c.ModelYear
                              }).ToList();
                return result;
            }
        }
    }
}
