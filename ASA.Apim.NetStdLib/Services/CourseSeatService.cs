﻿using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseSeats_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseSeatService : BaseService
    {
        public CourseSeatService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings) { }

        #region CourseSeats
        /// <summary>
        /// Get CourseSeats with details from Navision, using CourseSeats number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseSeats>> GetCourseSeatsByIdAsync(string accountFromHeader, string filter = "", int size = 0)
        {
            //if (string.IsNullOrEmpty(filter))
            //{
            //    //throw new Exception("Filter cannot be null or empty string.");
            //    return new List<CourseSeats>();
            //}

            var CourseSeatsfilter = SingleCourseSeatsFilter(filter, CourseSeats_Fields.No);
            return await GetCourseSeatssAsync(accountFromHeader, CourseSeatsfilter, size);
        }

        /// <summary>
        /// Get CourseSeats with details from Navision, using CourseSeats_Filter.
        /// </summary>
        /// <param name="filter">An instance of SalaryTeacherSpec_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseSeats>> GetCourseSeatssAsync(string accountFromHeader, CourseSeats_Filter[] filter, int size = 0)
        {
            return await GetCourseSeatsAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<CourseSeats>> GetCourseSeatsAsync(string accountFromHeader, CourseSeats_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<CourseSeats_ServiceClient, CourseSeats_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseSeatsAsync(): {exception.Message}");
            }
        }

        internal CourseSeats_Filter[] SingleCourseSeatsFilter(string criteria, CourseSeats_Fields field)
        {
            return new CourseSeats_Filter[]
            {
                new CourseSeats_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}
