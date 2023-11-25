using Business.Abstrack;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWrok;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserServices
    {
        private IUserDal _userdal;
        public UserManager(IUserDal userdal)
        {
            _userdal= userdal;
        }

        public void Add(User user)
        {
           _userdal.Add(user);//baseRepository
        }

        public User GetByMail(string email)
        {
           return _userdal.Get(u=>u.Email==email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userdal.GetClaims(user);//dataacces katmanından 
        }
    }
}
