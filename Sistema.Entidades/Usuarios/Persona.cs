using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades.Usuarios
{
    public class Persona
    {
        public int idpersona { get; set; }
        public int tipo_persona { get; set; }
        public string nombre { get; set; }
        public string tipo_documento { get; set; }
        public string num_documento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; } //este debe cambiar por mala practica
        public string email { get; set; }

    }
}
