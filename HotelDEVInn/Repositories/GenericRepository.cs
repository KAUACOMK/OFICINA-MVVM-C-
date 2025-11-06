using System;
using HotelDEVInn.Repositories;
using HotelDEVInn.Models;

namespace HotelDEVInn.Repositories
{
    public class GenericRepository<T>
    {
        private readonly List<T> _items;
        public GenericRepository(List<T> items) => _items = items;
        public List<T> GetAll() => new List<T>(_items);
        public List<T> Find(Func<T, bool> predicate) => _items.Where(predicate).ToList();
        public T FirstOrDefault(Func<T, bool> predicate) => _items.FirstOrDefault(predicate);
    }
}