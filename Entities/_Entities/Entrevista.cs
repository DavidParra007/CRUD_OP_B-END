using Entities._Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities._Entities
{
    public class Entrevista:EntityBase
    {
        //public int? id { get; set; }
        public int vacante { get; set; }
        public int prospecto { get; set; }
        public DateTime? fecha_entrevista { get; set; }  
        public string? notas { get; set; }
        public bool? reclutado { get; set; }
    }
}
