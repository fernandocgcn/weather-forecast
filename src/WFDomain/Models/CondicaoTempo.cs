using System;

namespace WFDomain.Models
{
    public class CondicaoTempo
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        public override bool Equals(object obj)
        {
            return obj is CondicaoTempo tempo &&
                   Sigla == tempo.Sigla;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Sigla);
        }
    }
}
