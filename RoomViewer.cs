using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWHousing.Data;
using UWHousing.Entities.ViewModels;

namespace UWHousing.BLL
{
    /// <summary>
    /// Business class for handling viewing of building view models
    /// </summary>
    public class RoomViewer
    {
        private readonly RoomDAO _roomDAO;

        public RoomViewer()
        {
            _room = new RoomDAO();
        }

        /// <summary>
        /// Returns view models of all rooms in a specific building
        /// </summary>
        public IList<RoomViewModel> GetAllRoomnumberBYAssigned(string no)
        {
            return _room.GetAllRoomnumber(Buildingname);
        }


    }
}
