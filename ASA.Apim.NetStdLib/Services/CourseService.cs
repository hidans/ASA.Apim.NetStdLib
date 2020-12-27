using ASA.Apim.NetStdLib.Entities;
using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using AutoMapper;
using CourseHeader_WebService;
using Department_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseService: BaseService
    {
        private readonly CourseCategoryService _courseCategoryService;
        public IEnumerable<string> CourseDepartmentsCodes { get; set; }

        public CourseService(ApiManagerCredentials credentials, AppSettings appSettings) :base(credentials, appSettings)
        {
            _courseCategoryService = new CourseCategoryService(credentials, appSettings);
        }

        #region CourseHeader
        /// <summary>
        /// Get one course with details from Navision, using course number
        /// </summary>
        /// <param name="courseNumber">Course id/number</param>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <returns></returns>
        public async Task<CourseHeader> GetCourseHeader(string accountFromHeader, string courseNumber)
        {
            return await GetCourseHeaderAsync(accountFromHeader, courseNumber);
        }
        internal async Task<CourseHeader> GetCourseHeaderAsync(string accountFromHeader, string courseNumber)
        {
            try
            {

                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<CourseHeader_ServiceClient, CourseHeader_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadAsync(courseNumber);
                await service.CloseAsync();

                return response.CourseHeader;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseHeader(): {exception.Message}");
            }
        }

        #endregion

        #region CourseHeaders
        /// <summary>
        /// Get CourseHeaders with details from Navision, using Catalog id as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeader>> GetCourseHeadersByCatalogIdAsync(string accountFromHeader, string filter = "", int size = 0)
        {
            var courseNos = await _courseCategoryService.GetCourseNosCriteriaByCatalogIdAsync(accountFromHeader, filter, size);
            var CourseHeaderfilter = SingleCourseHeaderFilter(courseNos, CourseHeader_Fields.No);
            var bookedLaunchedFilter = ExtendCourseHeaderFilter(CourseHeaderfilter, "booked|Launched", CourseHeader_Fields.GeneralCourseStatus);
            var task = await GetCourseHeaders(accountFromHeader, bookedLaunchedFilter, size);
            return task;
        }

        /// <summary>
        /// Get CourseHeaders with details from Navision, using Course number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeader>> GetCourseHeadersById(string accountFromHeader, string filter = "", int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<CourseHeader>();
            }

            var CourseHeaderfilter = SingleCourseHeaderFilter(filter, CourseHeader_Fields.No);
            var task = await GetCourseHeaders(accountFromHeader, CourseHeaderfilter, size);
            return task;
        }

        /// <summary>
        /// Get CourseHeaders with details from Navision, using Course number as filter.
        /// </summary>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeader>> GetCourseHeadersAsync(string accountFromHeader, int size = 0)
        {
           var CourseHeaderfilter = SingleCourseHeaderFilter(string.Empty, CourseHeader_Fields.No);
           var task = await GetCourseHeaders(accountFromHeader, CourseHeaderfilter, size);
           return task;
        }

        //public async Task<IEnumerable<CourseHeader>> GetCourseHeaders(string accountFromHeader, int size = 0)
        //{
        //    return await GetCourseHeadersById(accountFromHeader, "");
        //}

        /// <summary>
        /// Get CourseHeaders with details from Navision, using CourseHeader_Filter.
        /// </summary>
        /// <param name="filter">An instance of CourseHeader_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeader>> GetCourseHeaders(string accountFromHeader, CourseHeader_Filter[] filter, int size = 0)
        {
            return await GetCourseHeadersAsync(accountFromHeader, filter, size);
        }

        public async Task<IEnumerable<CourseHeader>> GetCourseHeadersAsync(string accountFromHeader, CourseHeader_Filter[] filter, int size = 0)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                //var service = ServiceClientHelper.CourseHeaderServiceClient(accountKey, subscriptionKey, appSettings);//Original

                #region usingGenerics
                //Client must gå through GenericServiceHelper.GetClient() to get credentials and environment ApimUrl. To Test.
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseHeader_ServiceClient, CourseHeader_Service>(Credentials, AppSettings); //Generic non static Class
                var service = genericServiceClientHelper.GetServiceClient();
                #endregion

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                var results = response.ReadMultiple_Result;
                CourseDepartmentsCodes = results.AsParallel().Select(c => c.CourseDepartment).Distinct();//Effect??
                return results.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseHeaders(): {exception.Message}");
            }
        }

        internal CourseHeader_Filter[] SingleCourseHeaderFilter(string criteria, CourseHeader_Fields field)
        {
            return new CourseHeader_Filter[]
            {
                new CourseHeader_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }

        internal CourseHeader_Filter[] ExtendCourseHeaderFilter(CourseHeader_Filter[] filter, string criteria, CourseHeader_Fields field)
        {
            return filter.Concat(SingleCourseHeaderFilter(criteria, field)).ToArray();
        }
        #endregion

        #region CourseHeadersWithDepartments
        /// <summary>
        /// Get CourseHeaders with Departments from Navision, using Department Number as filter.
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeaderWithDepartment>> GetCourseHeadersWithDepartmentByCourseDepartment(string filter, string accountFromHeader, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                return new List<CourseHeaderWithDepartment>();
            }

            var CourseHeaderfilter = SingleCourseHeaderFilter(filter, CourseHeader_Fields.CourseDepartment);
            return await GetCourseHeadersWithDepartments(CourseHeaderfilter, accountFromHeader, size);
        }

        /// <summary>
        /// Get all CourseHeaders with Departments from Navision.
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeaderWithDepartment>> GetCourseHeadersWithDepartmentByCourseDepartment(string accountFromHeader, int size = 0)
        {
            var CourseHeaderfilter = SingleCourseHeaderFilter("", CourseHeader_Fields.CourseDepartment);
            return await GetCourseHeadersWithDepartments(CourseHeaderfilter, accountFromHeader, size);
        }

        /// <summary>
        /// Get CourseHeaders with Departments from Navision, using Course Number
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeaderWithDepartment>> GetCourseHeadersWithDepartmentsById(string accountFromHeader, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                return new List<CourseHeaderWithDepartment>();
            }

            var CourseHeaderfilter = SingleCourseHeaderFilter(filter, CourseHeader_Fields.No);
            return await GetCourseHeadersWithDepartments(CourseHeaderfilter, accountFromHeader, size);
        }

        /// <summary>
        /// Get CourseHeaders with Departments from Navision, using Course Number and department.
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Required]</param>
        /// <param name="department">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Required]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeaderWithDepartment>> GetCourseHeadersWithDepartmentsByIdAndDepartment(string accountFromheader, string filter, string department, int size = 0)
        {
            if (string.IsNullOrEmpty(filter) || string.IsNullOrEmpty(department))
            {
                return new List<CourseHeaderWithDepartment>();
            }

            var courseHeaderfilter = SingleCourseHeaderFilter(filter, CourseHeader_Fields.No);
            var extendedCourseHeaderFilter = ExtendCourseHeaderFilter(courseHeaderfilter, department, CourseHeader_Fields.CourseDepartment);
            return await GetCourseHeadersWithDepartments(extendedCourseHeaderFilter, accountFromheader, size);
        }

        /// <summary>
        /// Get all CourseHeaders with Departments from Navision.
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeaderWithDepartment>> GetCourseHeadersWithDepartmentsById(string accountFromHeader, int size = 0)
        {
            var CourseHeaderfilter = SingleCourseHeaderFilter("", CourseHeader_Fields.No);
            return await GetCourseHeadersWithDepartments(CourseHeaderfilter, accountFromHeader, size);
        }

        /// <summary>
        /// Get all CourseHeaders with Departments from Navision
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeaderWithDepartment>> GetCourseHeadersWithDepartments(string accountFromHeader, int size = 0)
        {
            return await GetCourseHeadersWithDepartmentsById(accountFromHeader);
        }

        /// <summary>
        /// Get CourseHeaders with Departments from Navision, using CourseHeader_Filter.
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="filter">An instance of CourseHeader_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseHeaderWithDepartment>> GetCourseHeadersWithDepartments(CourseHeader_Filter[] filter, string accountFromHeader, int size = 0)
        {

            return await GetCourseHeadersWithDepartments(accountFromHeader,filter, size);
        }

        internal async Task<IEnumerable<CourseHeaderWithDepartment>> GetCourseHeadersWithDepartments(string accountFromHeader, CourseHeader_Filter[] filter, int size)
        {
            var list = new List<CourseHeaderWithDepartment>();
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var courseHeaders = await GetCourseHeaders(accountFromHeader, filter, size);
                if (courseHeaders != null && courseHeaders.Any())
                {
                    List<Department> departments = null;

                    var courseDepartments = courseHeaders.Select(x => x.CourseDepartment).Where(x => x != null).Distinct();
                    var criteria = Tools.GetCriteria(courseDepartments);
                    if (!string.IsNullOrEmpty(criteria))
                    {
                        var departmentService = new DepartmentService(Credentials, AppSettings);
                        departments = (await departmentService.GetDepartmentById(accountFromHeader, criteria)).ToList();
                    }

                    if (departments == null)
                    {
                        departments = new List<Department>();
                    }

                    foreach (var courseHeader in courseHeaders.Where(x => (x != null && !string.IsNullOrEmpty(x.CourseDepartment))).ToList())
                    {
                        var schooldepartments = departments.Any() ? departments.Where(x => x.Primary_Key.Equals(courseHeader.CourseDepartment)) : new List<Department>();
                        list.Add(new CourseHeaderWithDepartment(courseHeader,schooldepartments.FirstOrDefault()));
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseHeadersWithDepartments(): {exception.Message}");
            }

            return list;
        }
        #endregion

        #region CourseDepartmentRelation
        public async Task<List<CourseDepartmentRelation>> GetCourseDepartmentRelationsAsync(string accountFromHeader, List<CourseHeader> courseHeaders)
        {
            var results = new List<CourseDepartmentRelation>();
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                if (courseHeaders != null && courseHeaders.Any())
                {
                    List<Department> departments = null;

                    var courseDepartments = courseHeaders.Select(x => x.CourseDepartment).Where(x => x != null).Distinct();
                    var criteria = Tools.GetCriteria(courseDepartments);
                    if (!string.IsNullOrEmpty(criteria))
                    {
                        var departmentService = new DepartmentService(Credentials, AppSettings);
                        departments = (await departmentService.GetDepartmentById(accountFromHeader, criteria)).ToList();
                    }

                    if (departments == null)
                    {
                        departments = new List<Department>();
                    }

                    foreach (var courseHeader in courseHeaders.Where(x => (x != null && !string.IsNullOrEmpty(x.CourseDepartment))).ToList())
                    {
                        var schooldepartments = departments.Any() ? departments.Where(x => x.Primary_Key.Equals(courseHeader.CourseDepartment)) : new List<Department>();
                        var courseDepartmentRelation = new CourseDepartmentRelation() 
                        { 
                            CourseNo = courseHeader.No, 
                            DepartmentCode = courseHeader.CourseDepartment, 
                            DepartmentName = schooldepartments.FirstOrDefault().Name 
                        };
                        
                        results.Add(courseDepartmentRelation);
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseDepartmentRelationsAsync(): {exception.Message}");
            }

            return results;
        }
        #endregion
    }
}
