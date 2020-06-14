using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace BLL
{
    public class RespuestaConsulta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Recaudo> recaudos{ get; set; }
    }
}
