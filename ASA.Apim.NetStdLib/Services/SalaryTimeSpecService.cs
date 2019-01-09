﻿using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using SalaryTimeSpec_WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoMineAppSettings;

namespace ASA.Apim.NetStdLib.Services
{
    public class SalaryTimeSpecService: BaseService
    {
        public SalaryTimeSpecService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {

        }

        #region SalaryTimeSpec
        /// <summary>
        /// Get SalaryTimeSpecs with details from Navision, using Salary_Settled as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<SalaryTimeSpec>> GetSalaryTimeSpecsBySalarySettled(string accountFromHeader, DateTime fromDateTime, DateTime toDateTime, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<SalaryTimeSpec>();
            }

            var SalaryTimeSpecfilter = SingleSalaryTimeSpecFilter(filter, SalaryTimeSpec_Fields.Salary_Settled);
            return await GetSalaryTimeSpecs(accountFromHeader, fromDateTime, toDateTime, SalaryTimeSpecfilter, size);
        }

        /// <summary>
        /// Get CoursePriceType with details from Navision, using CoursePriceType_Filter.
        /// </summary>
        /// <param name="filter">An instance of CoursePriceType_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<SalaryTimeSpec>> GetSalaryTimeSpecs(string accountFromHeader, DateTime fromDateTime, DateTime toDateTime, SalaryTimeSpec_Filter[] filter, int size = 0)
        {
            return await GetSalaryTimeSpecsAsync(accountFromHeader, fromDateTime, toDateTime, filter, size);
        }

        internal async Task<IEnumerable<SalaryTimeSpec>> GetSalaryTimeSpecsAsync(string accountFromHeader, DateTime fromDateTime, DateTime toDateTime, SalaryTimeSpec_Filter[] filter, int size)
        {
            //If fromDate N/A it is set to Default(DateTime) i.e. DateTime.MinValue. If toDateTime N/A set it to DateTime.Now.
            if (toDateTime == DateTime.MinValue)
                toDateTime = DateTime.Now;

            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<SalaryTimeSpec_ServiceClient, SalaryTimeSpec_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = service.ReadMultipleAsync(filter, "", size).Result;
                await service.CloseAsync();
                //return response.ReadMultiple_Result.ToList();
                return response.ReadMultiple_Result.Where(r => 
                //r.Salary_Settled == false && 
                r.From_DateTime >= fromDateTime && 
                r.To_DateTime <= toDateTime
                ).OrderByDescending(t => t.From_DateTime);
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetSalaryTimeSpecsAsync(): {exception.Message}");
            }
        }

        internal SalaryTimeSpec_Filter[] SingleSalaryTimeSpecFilter(string criteria, SalaryTimeSpec_Fields field)
        {
            return new SalaryTimeSpec_Filter[]
            {
                new SalaryTimeSpec_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}