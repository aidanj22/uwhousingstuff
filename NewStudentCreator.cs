using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWHousing.Data;
using UWHousing.Entities.DTO;
using UWHousing.Entities.Persistence;
using UWHousing.Enum;
using UWHousing.Events;

namespace UWHousing.BLL
{
    /// <summary>
    /// Business object responsible for creating new students in the system
    /// </summary>
    public class NewStudentCreator
    {
        private readonly StudentDAO _studentDAO;

        public event EventHandler<StudentCreatedEventArgs> StudentCreated; //event delegate for when student is created

        public NewStudentCreator()
        {
            _studentDAO = new StudentDAO();

        }

        /// <summary>
        /// Creates a new student
        /// </summary>
        public void CreateStudent(NewStudentDTO newstudentDTO)
        {
            // create the studentDTO for persistence and populate its properties
            StudentDTO studentDTO = new StudentDTO()
            {
                student_id = newStudentDTO.student_id,
                student_first_name = newStudentDTO.first_name,
                student_last_name = newStudentDTO.last_name,
                building_name = newStudentDTO.building_name,
                room_number = newstudentDTO.room_number,
                meal_plan = newstudentDTO.meal_plan,
            };
            //formatting/syntax might be off here
        /// <summary>
        /// Trigger method called to raise the <see cref="NewStudentCreated"/> event
        /// </summary>
        protected virtual void OnStudentCreated(StudentDTO studentDTO)
        {
            //null test, without making a copy while keeping thread-safety
            StudentCreatedEventArgs args = new StudentCreatedEventArgs() { Student = studentDTO };
            StudentCreated?.Invoke(this, args);
        }
    }
}
