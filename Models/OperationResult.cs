namespace WcfServiceLibrary.Common.Models
{
    /// <summary>
    ///     Common class to hold properties for any operation.
    /// </summary>
    public class OperationResult
    {
        /// <summary>
        ///     Gets or sets the error message.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        ///     Gets or sets the friendly message.
        /// </summary>
        public string FriendlyMessage { get; set; }

        /// <summary>
        ///     Gets or sets the flag indicating whether the operation was successfull.
        /// </summary>
        public bool Success { get; set; }
    }
}
