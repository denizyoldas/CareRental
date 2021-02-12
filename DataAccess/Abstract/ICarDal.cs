using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        Car GetById(Expression<Func<Car, bool>> filter);
        List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
