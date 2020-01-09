using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ParserProcessoFromXml
{
    public class ParserBipBopBase
    {
        public XDocument Document { get; set; }

        public ParserBipBopBase(string document)
            : base()
        {
            Document = XDocument.Parse(document);
        }

        public IEnumerable<Processo> ParserData()
        {

            return
                from element in Document.Descendants("processo")
                select new Processo()
                {
                    NumeroProcesso = element.Element("numero_processo")?.Value,
                    Classe = element.Element("classe")?.Value,
                    DataDistribuicao = DateTime.TryParse(element.Element("distribuicao")?.Value, out var data) ? data : default,
                    Instancia = element.Element("instancia")?.Value,
                    Andamentos = CapturaAndamentos(element)
                };
        }

        private List<Andamento> CapturaAndamentos(XElement element)
        {
            return
               (from e in element.Descendants("andamento")
                select new Andamento()
                {
                    Data = DateTime.TryParse(e.Element("data")?.Value, out var data) ? data : default,
                    Descricao = e.Element("descricao")?.Value
                }).ToList();
        }
    }
}
