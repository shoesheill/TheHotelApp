using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TheHotelApp.Models;

namespace TheHotelApp.IServices
{
    public interface IGenericHotelService
    {
        //Task<IEnumerable<Room>> GetAllItemsAsync();
        string GetAllItemsAsync();

        Task<Room> GetItemByIdAsync(Guid? id);

        Task<IEnumerable<Room>> SearchFor(Expression<Func<Room, bool>> expression);

        Task CreateItemAsync(Room entity);

        Task EditItemAsync(Room entity);

        Task DeleteItemAsync(Room entity);
    }
}
