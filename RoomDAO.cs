using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAdventure.Entities.ViewModels;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
namespace UWHousing.Data
{
    /// <summary>
    /// Data access object for rooms
    /// </summary>
    public class RoomDAO
    {
        /// <summary>
        /// Returns view models of all available rooms in a building
        /// </summary>
        /// <returns></returns>
        public IList<RoomViewModel> GetAllOpenRoomsByBuilding(string Buildingname)
        {
            IList<RoomViewModel> room;

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UWHousing"].ConnectionString))
            {
                connection.Open();

                string sql = //need query to pull available rooms
                    ;
                room = connection.Query<RoomViewModel>(sql, new { Buildingname })
                    .ToList();

            }

            return room;
        }
    }
}

//Alternate version that I don't think is correct


using System.Configuration;
using System.Data.SqlClient;
using UWAdventure.Entities.Persistence;
using Dapper;
using UWHousing.Entities.DTO;
using UWHousing.Entities.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;
using UWAHousing.Enum;

namespace UWHousing.Data
{
    /// <summary>
    /// Data access object for rooms
    /// </summary>
    public class RoomDAO
    {

        /// <summary>
        /// Returns list of unassigned rooms
        /// </summary>
        public RoomViewModel GetRoomnumber()
        {
            IList<RoomViewModel> rooms = QueryForGetRoomnumber("room.Roomnumber=@Assigned = 'No'"); //not sure about the syntax here
            return rooms.Count > 0 ? rooms : null;
        }
