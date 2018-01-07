using System;
using System.Data;
using System.Data.SqlClient;
using WcfServiceLibrary.Common.Models;
using WcfServiceLibrary.Models;

namespace WcfServiceLibrary.Sql
{
    /// <summary>
    ///     Sql class to delete a student.
    /// </summary>
    public class SqlDeleteStudent
    {
        /// <summary>
        ///     Deletes a student based on Id.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public OperationResult DeleteStudent(DeleteStudentRequestModel request)
        {
            var response = new OperationResult();

            using (var connection = new SqlConnection(SqlConnectionString.ConnectionString))
            using (var command = new SqlCommand("usp_DeleteStudentById", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = request.Id;

                try
                {
                    connection.Open();
                    int deletedRows = command.ExecuteNonQuery();
                    if (deletedRows == 1)
                    {                        
                        response.Success = true;
                        response.FriendlyMessage = $"Student with Id {request.Id} deleted successfully.";
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
