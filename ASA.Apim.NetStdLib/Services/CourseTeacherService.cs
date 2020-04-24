using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseTeacher_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseTeacherService : BaseService
    {
        public CourseTeacherService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {

        }

        #region CourseTeacher
        public async Task<IEnumerable<CourseTeacher>> GetCourseTeacherById(string accountFromHeader, string filter = "", int size = 0)
        {
            var CourseTeacherfilter = SingleCourseTeacherFilter(filter, CourseTeacher_Fields.Teacher_No);
            var task = await GetCourseTeacher(accountFromHeader, CourseTeacherfilter, size);
            return task;
        }
        public async Task<IEnumerable<CourseTeacher>> GetCourseHeaders(string accountFromHeader, int size = 0)
        {
            return await GetCourseTeacherById(accountFromHeader, "");
        }

        public async Task<IEnumerable<CourseTeacher>> GetCourseTeacher(string accountFromHeader, CourseTeacher_Filter[] filter, int size = 0)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                //var service = ServiceClientHelper.CourseHeaderServiceClient(accountKey, subscriptionKey, appSettings);//Original

                #region usingGenerics
                //Client must gå through GenericServiceHelper.GetClient() to get credentials and environment ApimUrl. To Test.
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseTeacher_ServiceClient, CourseTeacher_Service>(Credentials, AppSettings); //Generic non static Class
                var service = genericServiceClientHelper.GetServiceClient();
                #endregion

                //var response = service.ReadMultipleAsync(filter, "", size).Result;//TODO: Replace with below also in other services
                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseTeacher(): {exception.Message}");
            }
        }

        internal CourseTeacher_Filter[] SingleCourseTeacherFilter(string criteria, CourseTeacher_Fields field)
        {
            return new CourseTeacher_Filter[]
            {
                new CourseTeacher_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}
