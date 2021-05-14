using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Almacen
{
    public class Almacen
    {
        public int idcategoria { get; set; }
        //Data Annotation para requerir u obligatorio
        [Required]
        //maximo de caracteres requeridos
        [StringLength(50, MinimumLength =3, ErrorMessage ="El nombre no debe tener más de 50 carácteres, por favor validar")];
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
