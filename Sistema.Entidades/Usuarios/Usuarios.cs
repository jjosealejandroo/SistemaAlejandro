using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema.Entidades.Usuarios
{
    public class Usuarios
    {
        public int idusuario { get; set; }
        //aqui debe agregar los dananotations para el usuario

        [Required]
        [StringLength(100, MinimumLength =10, ErrorMessage ="El nombre de usuario debe tener 100 caracteres o al menos 10")]
        public string nombre { get; set; }
        public string tipo_documento { get; set; }
        public string num_documento { get; set; }

        [Required]
        [StringLength(70, MinimumLength =25, ErrorMessage ="La direccion el maximo de caracteres debe ser de 70 o al menos 25")]
        public string direccion { get; set; }

        [Required]
        [StringLength(11, ErrorMessage ="El numero de telefono debe tener 11 digitos")]
        public string telefono { get; set; } 

        [Required]
        [StringLength(30, MinimumLength =10, ErrorMessage ="El correo debe tener maximo 30 caracteres o minimo 10")]
        [EmailAddress(ErrorMessage ="El email es un valor obligatorio")]
        public string email { get; set; }
        public string password_hash { get; set; }
        public string password_salt { get; set; }
        public bool condicion { get; set; }
        

    }
}
