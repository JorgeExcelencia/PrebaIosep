﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.DTOs
{
    public class InformeAfiliadosRequest
    {
        public int empresaId { get; set; }
        public string? periodo { get; set; }
    }
}