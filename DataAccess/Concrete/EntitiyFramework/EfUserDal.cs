using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilsemTeknik.DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BilsemTeknik.DataAccess.Concrete.EntitiyFramework
{
    public class EfUserDal : EfGenericRepository<User, BilsemTeknikContext>, IUserDAL
    {
    }
}
