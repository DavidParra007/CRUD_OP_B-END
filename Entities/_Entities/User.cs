using Entities._Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities._Entities
{
    public class User:EntityBase
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
               
    }
}
