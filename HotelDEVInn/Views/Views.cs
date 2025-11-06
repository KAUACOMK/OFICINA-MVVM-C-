using HotelDEVInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DEVInn.Views
{
    public class HotelView
    {
        public void ExibirTitulo(string title)
        {
            Console.WriteLine($"\n===== {title.ToUpper()} =====");
        }

        public void ExibirMensagem(string mensagem) => Console.WriteLine(mensagem);

        public void ExibirLista<T>(IEnumerable<T> list)
        {
            if (list == null || !list.Any())
            {
                Console.WriteLine("Nenhum item encontrado.");
                return;
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void ExibirCusto(Reserved reserved, decimal cost)
        {
            Console.WriteLine($"Custo total da reserva ID {reserved.Id} ({reserved.Guest.Name}): {cost:C}");
        }
    }
}
