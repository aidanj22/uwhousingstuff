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
    /// Business class responsible viewing student view models
    /// </summary>
    public class StudentViewer
    {
        private readonly StudentDAO _studentDAO;

        public StudentViewer()
        {
            _studentDAO = new StudentDAO();
        }

        /// <summary>
        /// Returns specified student?
        /// </summary>
        public List<StudentViewModel> GetStudent(student_id) //
        {
            return _studentDAO.GetStudent(student_id);
        }
    }
}