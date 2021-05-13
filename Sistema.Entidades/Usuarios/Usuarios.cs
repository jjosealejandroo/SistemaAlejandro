using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades.Usuarios
{
    public class Usuarios
    {
        public int idusuario { get; set; }
        //aqui debe agregar los dananotations
        public string nombre { get; set; }
        public string tipo_documento { get; set; }
        public string num_documento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; } //este atributo va a cambiar
        public string email { get; set; }
        public string password_hash { get; set; }
        public string password_salt { get; set; }
        public bool condicion { get; set; }


    }
}
