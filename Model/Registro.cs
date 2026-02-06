using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_semana_3.Model
{
    public class Registro
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public Registro(int numero, string nombre, string correo)
        {
            Numero = numero;
            Nombre = nombre;
            Correo = correo;
        }
    }
}