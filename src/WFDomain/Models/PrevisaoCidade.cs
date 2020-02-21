using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Serialization;

namespace WFDomain.Models
{
    [XmlRoot("cidade")]
    public class PrevisaoCidade
    {
        [XmlElement("nome")]
        public string Nome { get; set; }
        [XmlElement("uf")]
        public string Uf { get; set; }
        [XmlElement("atualizacao")]
        public string Atualizacao { get; set; }
        [XmlIgnore]
        public DateTime DataAtualizacao 
        { 
            get  { return DateTime.ParseExact(Atualizacao, "yyyy-MM-dd", CultureInfo.InvariantCulture); }
        }
        [XmlElement("previsao")]
        public List<Previsao> Previsoes { get; set; }
    }
}
