using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDEVInn.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string? Type  { get; set; }
        public decimal PriceForNight { get; set; }

        public override string ToString() => $"[Quarto Nº {Number}] Tipo: {Type}, Diaria: {PriceForNight:C}";
    }
}
