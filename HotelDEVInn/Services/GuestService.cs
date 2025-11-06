using HotelDEVInn.Models;
using HotelDEVInn.Repositories;

namespace HotelDEVInn.Services
{
    public class GuestService
    {
        private readonly GenericRepository<Guest> _repository;
        private readonly CsvService _csvService;

        public GuestService(GenericRepository<Guest> repository, CsvService csvService)
        {
            _repository = repository;
            _csvService = csvService;
        }

        public void ExportarParaCsv(string caminho)
        {
            var guests = _repository.GetAll();
            _csvService.Exportar(caminho, guests,
                () => "Id;Nome;CPF",
                g => $"{g.id};{g.Name};{g.CPF}");
        }
    }
}