using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TheHotelApp.IServices;
using TheHotelApp.Models;
using Dashboard;

namespace TheHotelApp.Services
{
    public class GenericHotelService : IGenericHotelService
    {
        //private readonly IGenericHotelService<TEntity> _context;
        //private readonly IHostingEnvironment _hostingEnvironment;
        public Task CreateItemAsync(Room entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItemAsync(Room entity)
        {
            throw new NotImplementedException();
        }

        public Task EditItemAsync(Room entity)
        {
            throw new NotImplementedException();
        }

        public string GetAllItemsAsync()
        {
            RoomService room = new RoomService();
            return room.GetAllRooms();
        }

        public Task<Room> GetItemByIdAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Room>> SearchFor(Expression<Func<Room, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
