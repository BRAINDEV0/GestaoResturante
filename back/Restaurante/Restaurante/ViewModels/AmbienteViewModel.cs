﻿using Restaurante.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurante.ViewModels
{
    public class AmbienteViewModel
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Por favor digite um nome", AllowEmptyStrings = true)]
        public string Nome { get; set; }

        public virtual ICollection<Mesa> Mesa { get; set; }
    }
}