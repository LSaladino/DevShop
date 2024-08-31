﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartilhado.Model
{
    public class Cliente
    {
        public string? Id { get; set; } 
        public string CPF { get; set; } = string.Empty;
        public string Nome { get; set;} = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
