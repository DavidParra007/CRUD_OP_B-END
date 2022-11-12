using Entities._Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities._Entities
{
    public class Vacante:EntityBase
    {
        //public int vacante { get; set; }
        [StringLength(50)]
        public string? area{ get; set; }
        public decimal? sueldo { get; set; }
        public bool? activo { get; set; }
    }
}
