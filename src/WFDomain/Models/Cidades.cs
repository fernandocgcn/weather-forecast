using System.Collections.Generic;
using System.Xml.Serialization;

namespace WFDomain.Models
{
    [XmlRoot("cidades")]
    public class Cidades
    {
        [XmlElement("cidade")]
        public List<Cidade> ListaCidade { get; set; }
    }
}
