using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceLibrary.Common.Models;
using WcfServiceLibrary.Models;
using WcfServiceLibrary.Sql;

namespace WcfServiceLibrary
{
    public class StudentService : IStudentService
    {
        public OperationResult CreateStudent(Student student)
        {
            return new SqlCreateStudent().Create(student);
        }

        public OperationResult DeleteStudent(DeleteStudentRequestModel student)
        {
            return new SqlDeleteStudent().DeleteStudent(student);
        }

        public GetStudentsResponseModel GetStudents()
        {
            return new SqlGetStudents().GetStudents();
        }

        public OperationResult UpdateStudent(Student student)
        {
            return new SqlUpdateStudent().UpdateStudent(student);
        }
    }
}
