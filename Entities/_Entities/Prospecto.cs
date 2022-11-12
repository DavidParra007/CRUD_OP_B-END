using Entities._Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities._Entities
{
    public class Prospecto:EntityBase
    {
        //public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string nombre{ get; set; }
        [StringLength(50)]
        public string correo { get; set; }
        public DateTime fecha_registro { get; set; }
        

    }
}
