using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_semana_3.Model;

namespace Trabajo_semana_3.Repositories
{
    public class RegistroRepository : IRegistroInterface
    {
        private List<Registro> registros = new List<Registro>();

        public void GuardarRegistro(Registro registro)
        {
            registros.Add(registro);
        }

        public int ConteoRegistro()
        {
            return registros.Count;
        }
    }
}