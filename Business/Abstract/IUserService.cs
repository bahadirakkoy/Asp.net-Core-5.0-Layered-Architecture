using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilsemTeknik.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetList();
        void Add(User user);
        void Update(User user);
        void Delete(int userId);
    }
}
