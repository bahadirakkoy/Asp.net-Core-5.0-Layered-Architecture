using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public short UserType { get; set; }
    }
}
