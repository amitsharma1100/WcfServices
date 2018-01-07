using WcfServiceLibrary.Common.Models;

namespace WcfServiceLibrary.Models
{
    /// <summary>
    ///     This class is the response of get student call.
    /// </summary>
    public class GetStudentResponseModel : OperationResult
    {
        /// <summary>
        ///     Gets or sets the student.
        /// </summary>
        Student Student { get; set; }
    }
}
