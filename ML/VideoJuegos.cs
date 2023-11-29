using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class VideoJuegos
    {
        public int IdVideoJuegos {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Año { get; set; }
        public string Compañia { get; set; }
        public int Ventas { get; set; }
        public List<ML.VideoJuegos> VideoJuegoss {  get; set; }
    }
}
