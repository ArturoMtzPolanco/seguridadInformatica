﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs.logs
{
    public class LogsDto
    {
        [Key]
        public int? Id { get; set; }

        public DateTime fecha { get; set; }

        public string nombreFuncion { get; set; }

        public string ip { get; set; }

        public string datos { get; set; }

        public string response { get; set; }

    }
}
