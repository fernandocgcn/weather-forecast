using System;
using System.Globalization;
using System.Xml.Serialization;

namespace WFDomain.Models
{
    public class Previsao
    {
        [XmlElement("dia")]
        public string Dia { get; set; }
        [XmlIgnore]
        public DateTime DataDia
        {
            get { return DateTime.ParseExact(Dia, "yyyy-MM-dd", CultureInfo.InvariantCulture); }
        }
        [XmlElement("tempo")]
        public string Tempo { get; set; }
        [XmlIgnore]
        public CondicaoTempo CondicaoTempo { get; set; }
        [XmlElement("maxima")]
        public int Maxima { get; set; }
        [XmlElement("minima")]
        public int Minima { get; set; }
        [XmlElement("iuv")]
        public decimal Iuv { get; set; }
    }
}
