using System;
using System.Xml.Serialization;

namespace WFDomain.Models
{
    public class Cidade
    {
        [XmlElement("id")]
        public int Id { get; set; }
        [XmlElement("nome")]
        public string Nome { get; set; }
        [XmlElement("uf")]
        public string Uf { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Cidade cidade &&
                   Id == cidade.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
