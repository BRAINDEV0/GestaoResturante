﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potatotech.GestaoRestaurante.Dominio.Models
{
    public class User : IdentityUser
    {
        public int TipoId { get; set; }
    }
}
