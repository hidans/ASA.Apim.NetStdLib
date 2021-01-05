using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using Department_WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvironmentAppsettings;
using ASA.Apim.NetStdLib.Models;

namespace ASA.Apim.NetStdLib.Services
{
    public class DepartmentService: BaseService
    {
        public DepartmentService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings) {}

        #region SchoolWithDepartments
        public async Task<IEnumerable<SchoolDepartment>> GetSchoolDepartmentsAsync(string accountFromHeader, List<string> departmentsCodes = null, int size = 0)
        {
            var schoolDepartments = new List<SchoolDepartment>();
            var filter = departmentsCodes != null && departmentsCodes.Count() > 0 ? Tools.GetCriteria(departmentsCodes) + "|''" : string.Empty;
           
            var departments = await GetDepartmentById(accountFromHeader, filter, size);
            
            var mainSchool = new SchoolDepartment();
            foreach (var dep in departments)
            {
                if (dep.Primary_Key == null)
                {
                    mainSchool.School = dep;
                    continue;
                }
                    

                if (!dep.Apply_School_Data_on_Reports)
                {
                    var schoolDep = new SchoolDepartment();
                    schoolDep.School = dep;
                    schoolDep.Departments.Add(dep);
                    schoolDepartments.Add(schoolDep);
                }
                else
                {
                    mainSchool.Departments.Add(dep);
                }
            }
            if (mainSchool.School != null && mainSchool.Departments.Any())
            {
                schoolDepartments.Add(mainSchool);
            }

            return schoolDepartments;
        }
        #endregion

        #region Department
        /// <summary>
        /// Get Departments with details from Navision, using Primary key as filter.
        /// </summary>
        /// <param name="accountFromHeader">Account</param>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Department>> GetDepartmentById(string accountFromHeader, string filter, int size = 0)
        {
            //if (string.IsNullOrEmpty(filter))
            //{
            //    //throw new Exception("Filter cannot be null or empty string.");
            //    return new List<Department>();
            //}

            var Departmentfilter = SingleDepartmentFilter(filter, Department_Fields.Primary_Key);
            return await GetDepartments(accountFromHeader, Departmentfilter, size);
        }

        /// <summary>
        /// Get Schools with details from Navision.
        /// </summary>
        /// <param name="accountFromHeader">Account</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Department>> GetSchools(string accountFromHeader, int size = 0)
        {
            var Departmentfilter = SingleDepartmentFilter("''", Department_Fields.Primary_Key);
            return await GetDepartments(accountFromHeader, Departmentfilter, size);
        }

        public async Task<IEnumerable<Department>> GetDepartments(string accountFromHeader, int size = 0)
        {
            return await GetDepartmentById(accountFromHeader, "");
        }

        /// <summary>
        /// Get Departments with details from Navision, using Department_Filter.
        /// </summary>
        /// <param name="filter">An instance of Department_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Department>> GetDepartments(string accountFromHeader, Department_Filter[] filter, int size = 0)
        {
            return await GetDepartmentsAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<Department>> GetDepartmentsAsync(string accountFromHeader, Department_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<Department_ServiceClient, Department_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetDepartmentsAsync(): {exception.Message}");
            }
        }

        internal Department_Filter[] SingleDepartmentFilter(string criteria, Department_Fields field)
        {
            return new Department_Filter[]
            {
                new Department_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }

        #endregion
    }
}
