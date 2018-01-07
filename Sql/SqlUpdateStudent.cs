using System;
using System.Data;
using System.Data.SqlClient;
using WcfServiceLibrary.Common.Models;
using WcfServiceLibrary.Models;

namespace WcfServiceLibrary.Sql
{
    /// <summary>
    ///     Sql class for update student.
    /// </summary>
    class SqlUpdateStudent
    {
        /// <summary>
        ///     This method updates student based on Id.
        /// </summary>
        /// <param name="student">Student to be updated.</param>
        /// <returns>Response of update.</returns>
        public OperationResult UpdateStudent(Student student)
        {
            var response = new OperationResult();

            using (var connection = new SqlConnection(SqlConnectionString.ConnectionString))
            using (var command = new SqlCommand("usp_UpdateStudentById", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = student.Id;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = student.Name;
                command.Parameters.Add("@Age", SqlDbType.Int).Value = student.Age;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = student.Address;
                command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = student.Gender;

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        response.Success = true;
                        response.FriendlyMessage = "Student Updated";
                    }
                }
                catch (Exception exception)
                {
                    response.ErrorMessage = exception.Message;
                }
            }

            return response;
        }
    }
}
