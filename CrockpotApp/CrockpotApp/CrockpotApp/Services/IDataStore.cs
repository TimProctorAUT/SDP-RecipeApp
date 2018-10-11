using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrockpotApp.Services
{
    /// <summary>
    /// IDataStore Interface - Includes Abstract Methods Declared in <see cref="MockDataStore"/>
    /// </summary>
    ///   
    /// <typeparam name="T"></typeparam>
    /// 
    ///<remarks>
    ///Variables:
    ///1) AddItemAsync                  - A Task which adds an Recipe Item to the Current RecipeList
    ///2) UpdateItemAsync               - A Task which Updates the RecipeList to show all current items
    ///3) DeleteItemAsync               - A Task which Deletes an Item from the RecipeList
    ///4) GetItemAsync                  - A Task which returns an Item
    ///5) GetItemsAsync                 - A Task which returns the RecipeList
    /// </remarks>                      - .
    public interface IDataStore<T>
    {

        Task<bool> AddItemAsync(T item);

        Task<bool> UpdateItemAsync(T item);

        Task<bool> DeleteItemAsync(string id);

        Task<T> GetItemAsync(string id);

        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
