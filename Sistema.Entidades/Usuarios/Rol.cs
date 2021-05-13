using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema.Entidades.Usuarios
{
   public class Rol
    {
        public int idrol { get; set; }
        [Required]
        [StringLength(30)]
        public string nombre { get; set; }
        [StringLength(100)]
        public string direccion { get; set; }
        public bool condicion { get; set; }

    }
}
