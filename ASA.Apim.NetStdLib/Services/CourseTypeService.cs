using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using ZoMineAppSettings;
using CourseType_WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseTypeService : BaseService
    {
        public CourseTypeService(ApiManagerCredentials credentials, AppSettings appSettings):base(credentials,appSettings)
        {
        }

        #region CourseType
        /// <summary>
        /// Get CourseType with details from Navision, using CourseType id as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<courseType>> GetCourseTypeById(string filter = "", int size = 0)
        {
            var CourseTypefilter = SingleCourseTypeFilter(filter, courseType_Fields.No);
            return await GetCourseTypesAsync(CourseTypefilter, size);
        }

        // <summary>
        /// Get all CourseType with details from Navision.
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<courseType>> GetCourseTypes(int size = 0)
        {
            return await GetCourseTypeById("");
        }

        /// <summary>
        /// Get CourseType with details from Navision, using CourseType_Filter.
        /// </summary>
        /// <param name="filter">An instance of CourseType_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<courseType>> GetCourseTypes(courseType_Filter[] filter, int size = 0)
        {
            return await GetCourseTypesAsync(filter, size);
        }

        internal async Task<IEnumerable<courseType>> GetCourseTypesAsync(courseType_Filter[] filter, int size)
        {
            try
            {
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseType_ServiceClient, CourseType_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = service.ReadMultipleAsync(filter, "", size).Result;
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseTypes(): {exception.Message}");
            }
        }

        internal courseType_Filter[] SingleCourseTypeFilter(string criteria, courseType_Fields field)
        {
            return new courseType_Filter[]
            {
                new courseType_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}
