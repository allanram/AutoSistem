using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Auto
{
    public class Automovel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int QuantidadeVendidos { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public string Bloco { get; set; }
    }
}
