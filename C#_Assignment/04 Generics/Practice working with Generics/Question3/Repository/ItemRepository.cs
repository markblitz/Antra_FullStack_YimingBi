using Question3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Repository
{
    internal class ItemRepository : IRepository<Item>
    {
        List<Item> _items;
        public ItemRepository()
        {
            _items = new List<Item>();
        }
        public void Add(Item item)
        {
            _items.Add(item);
        }

        public IEnumerable<Item> GetAll()
        {
            return _items;
        }

        public Item GetById(int id)
        {
            return (Item)_items[id];
        }

        public void Remove(Item item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
