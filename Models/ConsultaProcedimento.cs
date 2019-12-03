using System;
using System.Collections.Generic;

namespace SisCaVet.Models
{
    public class ConsultaProcedimento
    {
        public Consulta Consulta { get; set; }
        public Procedimento Procedimento { get; set; }
        public string  Resultado { get; set; }
    }
}