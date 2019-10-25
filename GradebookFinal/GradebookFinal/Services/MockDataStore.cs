using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradebookFinal.Models;

namespace GradebookFinal.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "COPRO2", Description="Computer Programming 2", schedule = "MWF 8:30AM - 10:00AM", room = "401", studcount = 43, studdropcount = 0 },
                new Item { Id = Guid.NewGuid().ToString(), Text = "ADDBASE", Description="Advance Database Systems", schedule = "TTH 11:30AM - 1:00PM", room = "503", studcount = 28, studdropcount = 0  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "FILIPO", Description="Filipino sa Akademikong Pananaliksik" , schedule = "SAT 6:30PM - 7:30PM", room = "301", studcount = 22, studdropcount = 0 },
                new Item { Id = Guid.NewGuid().ToString(), Text = "PHILITA", Description="Philippine Literature" , schedule = "WED 4:30PM - 7:00PM", room = "305", studcount = 43, studdropcount = 0 },
                new Item { Id = Guid.NewGuid().ToString(), Text = "COMARTS", Description="Communication and Arts", schedule = "MWF 2:30PM - 3:30PM", room = "511", studcount = 39, studdropcount = 0  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "FORLANG", Description="Foreign Language", schedule = "TUE 4:30PM - 5:30PM", room = "412", studcount = 32, studdropcount = 0  }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}