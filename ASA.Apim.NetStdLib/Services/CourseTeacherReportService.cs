using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseTeacherReport_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseTeacherReportService : BaseService
    {
        public CourseTeacherReportService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings){}

        #region CourseTeacherReport
        public async Task<string> GetTeacherContractAsync(string accountFromHeader, string courseNo, string teacherNo, int size = 0)
        {
            try
            {
                var key = (await GetCourseTeacherById(accountFromHeader, courseNo, teacherNo, size)).FirstOrDefault().Key;

                var result = await GetTeacherReportAsync(accountFromHeader, key);

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception($"Error in GetTeacherContractAsync(): {ex.Message}");
            }
        }

        public async Task<string> GetTeacherContractAsync(string accountFromHeader, string key, int size = 0)
        {
            try
            {
                //var key = (await GetCourseTeacherById(accountFromHeader, courseNo, teacherNo, size)).FirstOrDefault().Key;

                var result = await GetTeacherReportAsync(accountFromHeader, key);

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception($"Error in GetTeacherContractAsync(): {ex.Message}");
            }
        }

        /// <summary>
        /// Get Teachers with details from Navision, using Teacher number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseTeacherReport>> GetCourseTeacherById(string accountFromHeader, string courseNo, string teacherNo, int size = 0)
        {
            if (string.IsNullOrEmpty(courseNo))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return null;
            }

            var filter = SingleCourseTeacherReportFilter(courseNo, CourseTeacherReport_Fields.Course_Header_No);
            var extendedFilter = ExtendCourseTeacherReportFilter(filter, teacherNo, CourseTeacherReport_Fields.Teacher_No);
            return await GetCourseTeacherReport(accountFromHeader, extendedFilter, size);
        }

        /// <summary>
        /// Get CourseTeacherReports with details from Navision, using CourseTeacherReport_Filter.
        /// </summary>
        /// <param name="filter">An instance of CourseTeacherReport_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseTeacherReport>> GetCourseTeacherReport(string accountFromHeader, CourseTeacherReport_Filter[] filter, int size = 0)
        {
            return await GetCourseTeacherReportAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<CourseTeacherReport>> GetCourseTeacherReportAsync(string accountFromHeader, CourseTeacherReport_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<CourseTeacherReport_ServiceClient, CourseTeacherReport_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetSalaryTimeSpecsAsync(): {exception.Message}");
            }
        }


        internal async Task<string> GetTeacherReportAsync(string accountFromHeader, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return null;
            }

            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<CourseTeacherReport_ServiceClient, CourseTeacherReport_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();
                var request = new GenTeacherReportRequest(key, 1, string.Empty);
                var response = await service.GenTeacherReportAsync(request);
                await service.CloseAsync();
                return response.bin64String;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetTeacherReportAsync(): {exception.Message}");
            }
        }


        internal CourseTeacherReport_Filter[] SingleCourseTeacherReportFilter(string criteria, CourseTeacherReport_Fields field)
        {
            return new CourseTeacherReport_Filter[]
            {
                new CourseTeacherReport_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }

        internal CourseTeacherReport_Filter[] ExtendCourseTeacherReportFilter(CourseTeacherReport_Filter[] filter, string criteria, CourseTeacherReport_Fields field)
        {
            return filter.Concat(SingleCourseTeacherReportFilter(criteria, field)).ToArray();
        }
        #endregion

    }
}
