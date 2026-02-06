using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_semana_3.Model;

namespace Trabajo_semana_3.Repositories
{
    public interface IRegistroInterface
    {
        void GuardarRegistro(Registro registro);
        
        int ConteoRegistro();
    }
}
