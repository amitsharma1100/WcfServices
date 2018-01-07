using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WcfServiceLibrary.Models;

namespace WcfServiceLibrary.Sql
{
    /// <summary>
    ///     Sql class to retrieve all students.
    /// </summary>
    public class SqlGetStudents
    {
        /// <summary>
        ///     This method returns all the students list.
        /// </summary>
        /// <returns>The list containing all the students.</returns>
        public GetStudentsResponseModel GetStudents()
        {
            var response = new GetStudentsResponseModel
            {
                Students = new List<Student>(),
            };

            using (var connection = new SqlConnection(SqlConnectionString.ConnectionString))
            using (var command = new SqlCommand("usp_GetAllStudents", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            response.Students.Add(new Student
                            {
                                Address = reader["Address"].ToString(),
                                Age = Convert.ToInt32((reader["Age"])),
                                Gender = reader["Gender"].ToString(),
                                Id = Convert.ToInt32((reader["Id"])),
                                Name = reader["Name"].ToString(),
                            });
                        }
                        response.Success = true;
                        response.FriendlyMessage = "Retrieved students data successfully.";
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
