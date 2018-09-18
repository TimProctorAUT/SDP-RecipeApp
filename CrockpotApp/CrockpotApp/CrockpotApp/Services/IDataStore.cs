using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrockpotApp.Services
{
    /// <summary>
    /// IDataStore Interface - Includes Abstract Methods Declared in <see cref="MockDataStore"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataStore<T>
    {

        Task<bool> AddItemAsync(T item);

        Task<bool> UpdateItemAsync(T item);

        Task<bool> DeleteItemAsync(string id);

        Task<T> GetItemAsync(string id);

        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
