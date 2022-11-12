using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities._Interface
{
    public interface IEntidadBase
    {
        public int Id { get; set; }
        public DateTime Added { get; set; }
        public DateTime Updated { get; set; }
        public bool Active { get; set; }
    }
}
