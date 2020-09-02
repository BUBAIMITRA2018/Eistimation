using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Estimationtool.Services
{
    public interface IDataStore<T>
    {
        List<string> AddItemAsync(string propertyname);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<List<T>> GetListOfItemAsync(string searchitem, string searchvalue);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
