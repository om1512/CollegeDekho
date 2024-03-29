using System.ServiceModel;

namespace CollegeDekhoService
{
    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        Admin GetAdminById(int adminId);

        [OperationContract]
        bool findAdminByUsernameAndPassword(string username, string password);
    }
}
