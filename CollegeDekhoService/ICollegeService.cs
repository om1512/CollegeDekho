using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;

namespace CollegeDekhoService
{
    [ServiceContract] 
    internal interface ICollegeService
    {
        [OperationContract]
        DataSet GetAllColleges();

        [OperationContract]
        College GetCollegeById(int id);

        [OperationContract]
        College GetCollegeByName(string name);

        [OperationContract]
        College GetCollegeByPlace(string place);

        [OperationContract]
        List<College> listOfAllCollege();

        [OperationContract]
        void saveCollege(College college);

        [OperationContract]
        void DeleteCollegeById(int id);

        [OperationContract]
        string UpdateCollegeById(int id, College college);

    }
}
