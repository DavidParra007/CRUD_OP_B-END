using Entities._Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities._Entities
{
    public class Post:EntityBase
    {
        [Required]
        public int userid { get; set; }
        [StringLength(5)]
        [Required]
        public string title { get; set; }
        public string body { get; set; }

    }
}
