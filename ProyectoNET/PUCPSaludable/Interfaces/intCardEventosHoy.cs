using PUCPSaludable.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUCPSaludable.Interfaces
{
    public interface intCardEventosHoy
    {
        string Titulo { get; set; }
        string Descripcion { get; set; }
        EDeportes TipoEvento { get; set; }
    }
}
