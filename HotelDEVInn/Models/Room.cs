using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DEVInn.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string? Tipe  { get; set; }
        public decimal PriceForNight { get; set; }

        public override string ToString() => $"[Quarto Nº {Number}] Tipo: {Tipe}, Diaria: {PriceForNight:C}";
    }
}
