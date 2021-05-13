using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema.Entidades.Almacen
{
    public class Categoria
    {
        public int idcategoria { get; set;  }
        [Required]
        [StringLength (50, MinimumLength =3, ErrorMessage ="El nombre debe tener maximo de 50 caracteres, y no menos de 3.")]
        public string nombre { get; set;  }
        [StringLength(256, ErrorMessage ="Tamano maximo de direccion 256.")]
        public string descrpcion { get; set; }
        public bool condicion { get; set; }
    }
}
