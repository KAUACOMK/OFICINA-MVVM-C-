using HotelDEVInn.Services;
using HotelDEVInn.Models;
using HotelDEVInn.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Hotel_DEVInn.Services
{
    public class QuartoService
    {
        private readonly GenericRepository<Room> _repository;
        private readonly CsvService _csvService;

        public QuartoService(GenericRepository<Room> repository, CsvService csvService)
        {
            _repository = repository;
            _csvService = csvService;
        }

        public void ExportarParaCsv(string caminho)
        {
            var rooms = _repository.GetAll();
            _csvService.Exportar(caminho, rooms,
                () => "Id;Numero;Tipo;PrecoPorNoite",
                r => $"{r.Id};{r.Number};{r.Type};{r.PriceForNight.ToString(CultureInfo.InvariantCulture)}");
        }
    }

}
