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
    /// Data access object for housing
    /// </summary>
    public class BuildingDAO
    {

        /// <summary>
        /// Returns list of buildings
        /// </summary>
        public BuildingViewModel GetBuildingname()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UWHousing"].ConnectionString)) //I don't think this is right but we need to connect somewhere
            {
                connection.Open();
                IList<BuildingViewModel> names = QueryForGetBuildingname("building.buildingname=@*");
                return names.Count > 0 ? names : null;
        }
