using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Teacher_WebService;

namespace ASA.Apim.NetStdLib.Services
{
    public class TeacherService : BaseService
    {
        public TeacherService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {

        }

        #region Teacher
        /// <summary>
        /// Get Teachers with details from Navision, using Teacher number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Teacher>> GetTeacherById(string accountFromHeader, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<Teacher>();
            }

            var Teacherfilter = SingleTeacherFilter(filter, Teacher_Fields.No);
            return await GetTeacher(accountFromHeader, Teacherfilter, size);
        }

        /// <summary>
        /// Get SalaryTeacherSpecs with details from Navision, using SalaryTeacherSpec_Filter.
        /// </summary>
        /// <param name="filter">An instance of SalaryTeacherSpec_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Teacher>> GetTeacher(string accountFromHeader, Teacher_Filter[] filter, int size = 0)
        {
            return await GetTeacherAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<Teacher>> GetTeacherAsync(string accountFromHeader, Teacher_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<Teacher_ServiceClient, Teacher_Service>(Credentials, AppSettings);
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

        internal Teacher_Filter[] SingleTeacherFilter(string criteria, Teacher_Fields field)
        {
            return new Teacher_Filter[]
            {
                new Teacher_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion

    }
}
