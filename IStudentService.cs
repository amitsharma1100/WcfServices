using System.ServiceModel;
using WcfServiceLibrary.Common.Models;
using WcfServiceLibrary.Models;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        OperationResult CreateStudent(Student student);        

        [OperationContract]
        GetStudentsResponseModel GetStudents();

        [OperationContract]
        OperationResult UpdateStudent(Student student);

        [OperationContract]
        OperationResult DeleteStudent(DeleteStudentRequestModel student);
    }
}
