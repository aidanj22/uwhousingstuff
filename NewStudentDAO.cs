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
    /// Data access object for students 
    /// </summary>
    public class StudentDAO
    {

        /// <summary>
        /// Creates a new student
        /// </summary>
        public void CreateStudent(NewStudentDTO newstudentDTO)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["uwhousing"].ConnectionString)) //placeholder
            {
                connection.Open();
                string sql //query
                    
                connection.Execute(sql, new { newstudentDTO }o);
            }
           
        }
  