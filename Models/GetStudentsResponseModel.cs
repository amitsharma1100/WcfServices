using System.Collections.Generic;
using WcfServiceLibrary.Common.Models;

namespace WcfServiceLibrary.Models
{
    /// <summary>
    ///     This class holds the response for get all students call.
    /// </summary>
    public class GetStudentsResponseModel : OperationResult
    {
        /// <summary>
        ///     Gets or sets the list of all students.
        /// </summary>
       public IList<Student> Students { get; set; }
    }
}
