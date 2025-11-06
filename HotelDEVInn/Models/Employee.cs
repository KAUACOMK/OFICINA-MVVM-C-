using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DEVInn.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string? Name { get; set; }

        public override string ToString() => $"[Funcionario] Nome: {Name}";
         
       
    }
}
