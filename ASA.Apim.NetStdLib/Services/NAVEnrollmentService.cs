using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CourseEnrollments_WebService;
using EnvironmentAppsettings;

namespace ASA.Apim.NetStdLib.Services
{
    public class NAVEnrollmentService
    {
        private readonly ApiManagerCredentials _credentials;
        private readonly AppSettings _appSettings;

        public NAVEnrollmentService(ApiManagerCredentials credentials, AppSettings appSettings)
        {
            _credentials = credentials;
            _appSettings = appSettings;
        }

        #region CourseEnrollment
        /// <summary>
        /// Creates all course participants in the provided CourseEnrollment list.
        /// </summary>
        /// <param name="courseEnrollments">Every enrollment equals 1 CourseEnrollment. i.e. 7 persons for the same course will count as 7 CourseEnrollments.</param>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <returns></returns>
        public async Task<bool> CreateCourseEnrollment(IEnumerable<CourseEnrollment> courseEnrollments)
        {
            return await CreateCourseEnrollmentAsync(courseEnrollments);
        }
        internal async Task<bool> CreateCourseEnrollmentAsync(IEnumerable<CourseEnrollment> courseEnrollments)
        {
            try
            {
                var cEnrollments = courseEnrollments;
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseEnrollments_ServiceClient, CourseEnrollments_Service>(_credentials, _appSettings);
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
