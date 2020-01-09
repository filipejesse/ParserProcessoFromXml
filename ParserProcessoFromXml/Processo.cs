using System;
using System.Collections.Generic;

namespace ParserProcessoFromXml
{
    public class Processo
    {
        public string NumeroProcesso { get; set; }
        public string Classe { get; set; }
        public DateTime DataAutuacao { get; set; }
        public DateTime DataDistribuicao { get; set; }
        public string Origem { get; set; }
        public string Instancia { get; set; }
        public List<Andamento> Andamentos { get; set; }
    }
}
