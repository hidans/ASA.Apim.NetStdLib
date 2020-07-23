using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using ParticipantNewsLetter_WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class ParticipantNewsLetterService : BaseService
    {
        public ParticipantNewsLetterService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {

        }

        #region ParticipantNewsLetter
        /// <summary>
        /// Get ParticipantNewsLetters with details from Navision, using Teacher number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<ParticipantNewsLetter>> GetParticipantNewsLetterById(string accountFromHeader, string filter, int size = 0)
        {
            if (string.IsNullOrEmpty(filter))
            {
                //throw new Exception("Filter cannot be null or empty string.");
                return new List<ParticipantNewsLetter>();
            }

            var ParticipantNewsLetterfilter = SingleParticipantNewsLetterFilter(filter, ParticipantNewsLetter_Fields.No);
            return await GetParticipantNewsLetters(accountFromHeader, ParticipantNewsLetterfilter, size);
        }

        /// <summary>
        /// Get ParticipantNewsLetters with details from Navision, using Teacher number as filter.
        /// </summary>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<ParticipantNewsLetter>> GetParticipantNewsLetterWithPermission(string accountFromHeader, int size = 0)
        {
            

            var ParticipantNewsLetterfilter = SingleParticipantNewsLetterFilter("true", ParticipantNewsLetter_Fields.Permission_to_E_mail);
            return await GetParticipantNewsLetters(accountFromHeader, ParticipantNewsLetterfilter, size);
        }

        //public async Task<IEnumerable<SalaryTeacherSpec>> GetSalaryTeacherSpecs(string accountFromHeader, string filter = "", int size = 0)
        //{
        //   var SalaryTeacherSpecfilter = SingleSalaryTeacherSpecFilter(filter, SalaryTeacherSpec_Fields.No);
        //    return await GetSalaryTeacherSpecs(accountFromHeader, SalaryTeacherSpecfilter, size);
        //}

        /// <summary>
        /// Get ParticipantNewsLetters with details from Navision, using ParticipantNewsLetter_Filter.
        /// </summary>
        /// <param name="filter">An instance of ParticipantNewsLetter_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<ParticipantNewsLetter>> GetParticipantNewsLetters(string accountFromHeader, ParticipantNewsLetter_Filter[] filter, int size = 0)
        {
            return await GetParticipantNewsLettersAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<ParticipantNewsLetter>> GetParticipantNewsLettersAsync(string accountFromHeader, ParticipantNewsLetter_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<ParticipantNewsLetter_ServiceClient, ParticipantNewsLetter_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetParticipantNewsLettersAsync(): {exception.Message}");
            }
        }

        internal ParticipantNewsLetter_Filter[] SingleParticipantNewsLetterFilter(string criteria, ParticipantNewsLetter_Fields field)
        {
            return new ParticipantNewsLetter_Filter[]
            {
                new ParticipantNewsLetter_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion

    }
}
