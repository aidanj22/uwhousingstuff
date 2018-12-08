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
