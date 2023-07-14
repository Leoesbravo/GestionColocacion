using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Grupo
    {
        public int IdGrupo { get; set; }
        public string FechaIngreso { get; set; }
        public string Nombre { get; set; }
        public string FechaEgreso { get; set; }
        public TipoGrupo TipoGrupo { get; set; }
        public Status Status { get; set; }
        public List<object> Grupos { get; set; }
        public Usuario Usuario { get; set;}
        public List<object> Coaches { get; set; }
    }
}
