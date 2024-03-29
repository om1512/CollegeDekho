using System.Collections.Generic;
using System.ServiceModel;

namespace CollegeDekhoService
{
    [ServiceContract]
    public interface ICourseService
    {
        [OperationContract]
        Course GetCourseById(int courseId);

        [OperationContract]
        void AddCourse(Course course);

        [OperationContract]
        void UpdateCourse(Course course);

        [OperationContract]
        void DeleteCourse(int courseId);

        [OperationContract]
        List<Course> GetCoursesByCollegeId(int collegeId);
    }
}
