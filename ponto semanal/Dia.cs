using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponto_semanal
{
    public class dia
    {
        public DateTime Data  { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? SaidaAlmoco { get; set; }
        public DateTime? VoltaAlmoco { get; set; }
        public DateTime? Saida { get; set; }
        
        public DateTime? totalHoras { get; set; } 

       
        
    }
}

