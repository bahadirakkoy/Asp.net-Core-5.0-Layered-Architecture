using BilsemTeknik.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using BilsemTeknik.DataAccess.Abstract;

namespace BilsemTeknik.Business.Concrete
{
    public class UserManager : IUserService
        
    {
        private IUserDAL _userDal;
        public UserManager(IUserDAL userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(int userId)
        {
            _userDal.Remove(new User { UserId = userId });
        }

        public List<User> GetList()
        {
            var users = _userDal.GetList();
            return users.ToList();
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
