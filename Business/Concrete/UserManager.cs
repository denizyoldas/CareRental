using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _UserDal;
        public IResult Add(User user)
        {
            _UserDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _UserDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<User> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            var result = _UserDal.GetAll();
            return new SuccessDataResult<List<User>>(result);
        }

        public IResult Update(User user)
        {
            _UserDal.Update(user);
            return new SuccessResult();
        }
    }
}
