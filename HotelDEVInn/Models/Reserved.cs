using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DEVInn.Models
{
    public class Reserved
    {
        public int Id { get; set; }
        public Room? ReservedRoom { get; set; }
        public Guest? Guest { get; set; }
        public Employee? Employee { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }

        public override string ToString()
        {
            return $"--- Reserva ID: {Id} ---\n" +
                   $"\tHospede: {Guest?.Name}\n" +
                   $"\tQuarto: {ReservedRoom?.Number}" +
                   $"\tPeríodo: {DateCheckIn:dd/MM/yyyy} a {DateCheckOut:dd/MM/yyyy}\n" +
                   $"\tAtendente: {Employee?.Name}\n";
        }
    }
}
