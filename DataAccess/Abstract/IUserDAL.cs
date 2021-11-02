using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace BilsemTeknik.DataAccess.Abstract
{
    public interface IUserDAL: IGenericDAL<User>
    {
        //Custom Operations
    }
}
