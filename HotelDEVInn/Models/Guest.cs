using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DEVInn.Models
{
    public class Guest
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public string? CPF { get; set; }

        public override string ToString() => $"[Hospede] Nome: {Name} CPF: {CPF}";
    }
}
