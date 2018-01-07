using System;
using System.Data;
using System.Data.SqlClient;
using WcfServiceLibrary.Common.Models;
using WcfServiceLibrary.Models;

namespace WcfServiceLibrary.Sql
{
    /// <summary>
    ///     Sql class to create a new student.
    /// </summary>
    public class SqlCreateStudent
    {
        /// <summary>
        ///     This method creates a new student.
        /// </summary>
        /// <param name="student">The student request.</param>
        /// <returns>Response of the create process.</returns>
        public OperationResult Create(Student student)
        {
            var response = new OperationResult();

            using (var connection = new SqlConnection(SqlConnectionString.ConnectionString))
            using (var command = new SqlCommand("usp_CreateStudent", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
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
                        response.FriendlyMessage = "Student Created";
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
