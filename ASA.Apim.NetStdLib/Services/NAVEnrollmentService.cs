using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseEnrollments_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class NAVEnrollmentService:BaseService
    {
        public NAVEnrollmentService(ApiManagerCredentials credentials, AppSettings appSettings): base(credentials, appSettings){}

        #region CourseEnrollment
        /// <summary>
        /// Creates all course participants in the provided CourseEnrollment list.
        /// </summary>
        /// <param name="courseEnrollments">Every enrollment equals 1 CourseEnrollment. i.e. 7 persons for the same course will count as 7 CourseEnrollments.</param>
        /// <param name="accountFromHeader">Account key from Navision. [Required]</param>
        /// <returns></returns>
        public async Task<bool> CreateCourseEnrollment(string accountFromHeader, IEnumerable<CourseEnrollment> courseEnrollments)
        {
            return await CreateCourseEnrollmentAsync(accountFromHeader, courseEnrollments);
        }
        internal async Task<bool> CreateCourseEnrollmentAsync(string accountFromHeader, IEnumerable<CourseEnrollment> courseEnrollments)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var cEnrollments = courseEnrollments;
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseEnrollments_ServiceClient, CourseEnrollments_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var navCourseEnrollments = new CourseEnrollments { CourseEnrollment = courseEnrollments.ToArray() };

                CourseEnrollmentsRequest request = new CourseEnrollmentsRequest(navCourseEnrollments);
                var response = service.CourseEnrollmentsAsync(request);
                await service.CloseAsync();

                return true;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in CreateCourseEnrollment(): {exception.Message}");
            }
        }
        #endregion


    }
}
