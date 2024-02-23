using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
        [Table ("users")]
        public class users
        {
            [Key]
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Ap_paterno { get; set; }
    }
}
