using HotelDEVInn.Models;
using HotelDEVInn.Repositories;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DEVInn.Services
{
    public class ReservaService
    {
        private readonly GenericRepository<Reserved> _reservaRepository;
        private readonly GenericRepository<Room> _quartoRepository;

        public ReservaService(GenericRepository<Reserved> reservaRepo, GenericRepository<Room> quartoRepo)
        {
            _reservaRepository = reservaRepo;
            _quartoRepository = quartoRepo;
        }

        public List<Reserved> ListarTodas() => _reservaRepository.GetAll();

        public List<Reserved> EncontrarPorNomeHospede(string name)
        {
            return _reservaRepository.Find(r => r.Guest.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public decimal CalcularCustoReserva(Reserved reserved)
        {
            var numeroNoites = (reserved.DateCheckOut - reserved.DateCheckIn).Days;
            return numeroNoites > 0 ? numeroNoites * reserved.ReservedRoom.PriceForNight : reserved.ReservedRoom.PriceForNight;
        }

        public List<Room> ListarQuartosDisponiveis(DateTime checkIn, DateTime checkOut)
        {
            var todasReservas = _reservaRepository.GetAll();
            var todosQuartos = _quartoRepository.GetAll();

            // Encontra IDs de quartos cujas reservas conflitam com o período desejado
            var quartosOcupadosIds = todasReservas
                .Where(r => (checkIn < r.DateCheckOut) && (r.DateCheckOut < checkOut))
                .Select(r => r.ReservedRoom.Id)
                .ToHashSet();

            // Retorna os quartos cujo ID não está na lista de ocupados
            return todosQuartos.Where(q => !quartosOcupadosIds.Contains(q.Id)).ToList();
        }
    }
}
