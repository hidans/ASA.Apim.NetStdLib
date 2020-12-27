using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using Catalog_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CatalogService : BaseService
    {
        public CatalogService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings){}

        #region Category
        /// <summary>
        /// Get catalogs with details from Navision, using catalog number as filter.
        /// </summary>
        /// <param name="accountFromHeader">Account key from Navision. [Required]</param>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Catalog>> GetCategoriesByIdAsync(string accountFromHeader, string filter = "", int size = 0)
        {
            var Catalogfilter = SingleCatalogFilter(filter, Catalog_Fields.Id);
            return await GetCategoriesAsync(accountFromHeader, Catalogfilter, size);
        }

        /// <summary>
        /// Get all Categories.
        /// </summary>
        /// <param name="accountFromHeader">Account key from Navision. [Required]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Catalog>> GetCategoriesAsync(string accountFromHeader, int size = 0)
        {
            return await GetCategoriesByIdAsync(accountFromHeader);
        }

        /// <summary>
        /// Get Catalogss with details from Navision, using Catalog_Filter.
        /// </summary>
        /// <param name="filter">An instance of Catalog_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Catalog>> GetCategoriesAsync(string accountFromHeader, Catalog_Filter[] filter, int size = 0)
        {
            var criteria = "false";
            filter = ExtendCatalogFilter(filter, criteria, Catalog_Fields.Catalog);

            return await GetCatalogAsync(accountFromHeader, filter, size);
        }

        #endregion

        #region Catalog
        /// <summary>
        /// Get catalogs with details from Navision, using catalog description as filter.
        /// </summary>
        /// <param name="accountFromHeader">Account key from Navision. [Required]</param>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Catalog>> GetCatalogByNameAsync(string accountFromHeader, string filter = "", int size = 0)
        {
            var Catalogfilter = SingleCatalogFilter(filter, Catalog_Fields.Description);
            return await GetCatalogsAsync(accountFromHeader, Catalogfilter, size);
        }

        /// <summary>
        /// Get catalogs with details from Navision, using catalog number as filter.
        /// </summary>
        /// <param name="accountFromHeader">Account key from Navision. [Required]</param>
        /// <param name="filter">Search: All records starting with for instance 10 -> "10..", all records ending with f.i. 10 -> "..10", record with id = 1014 -> "1014" or any record with id in (1014,1015,1016) -> "1014|1015|1016" [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Catalog>> GetCatalogByIdAsync(string accountFromHeader, string filter = "", int size = 0)
        {
            var Catalogfilter = SingleCatalogFilter(filter, Catalog_Fields.Id);
            return await GetCatalogsAsync(accountFromHeader, Catalogfilter, size);
        }

        /// <summary>
        /// Get all Catalogs.
        /// </summary>
        /// <param name="accountFromHeader">Account key from Navision. [Required]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Catalog>> GetCatalogsAsync(string accountFromHeader, int size = 0)
        {
            return (await GetCatalogByIdAsync(accountFromHeader)).Where(c => (
            c.Portal_Available));
        }

        /// <summary>
        /// Get all Active Catalogs for a given date.
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountFromHeader">Account key from Navision. [Required]</param>
        /// <param name="activeDate">A given date. [Optional]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Catalog>> GetActiveCatalogsAsync(string accountFromHeader, DateTime activeDate, int size = 0)
        {
            return (await GetCatalogByIdAsync(accountFromHeader)).Where(c => (
            c.Portal_Available &&
            (c.Catalog_From_Date <= activeDate || c.Catalog_From_Date == DateTime.MinValue) &&
            (c.Catalog_To_Date.AddDays(1) >= activeDate || c.Catalog_To_Date == DateTime.MinValue)
            ));
        }


        /// <summary>
        /// Get all Active Catalogs for today's date.
        /// </summary>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Catalog>> GetActiveCatalogsAsync(string accountFromHeader, int size = 0)
        {
            return await GetActiveCatalogsAsync(accountFromHeader, DateTime.Now, size);
        }



        /// <summary>
        /// Get Catalogss with details from Navision, using Catalog_Filter.
        /// </summary>
        /// <param name="filter">An instance of Catalog_Filter.</param>
        /// <param name="size">Maximum returned records. 0 returns all records. [Optional]</param>
        /// <returns></returns>
        public async Task<IEnumerable<Catalog>> GetCatalogsAsync(string accountFromHeader, Catalog_Filter[] filter, int size = 0)
        {
            var criteria = "true";
            filter = ExtendCatalogFilter(filter, criteria, Catalog_Fields.Catalog);

            return await GetCatalogAsync(accountFromHeader, filter, size);
        }

        internal async Task<IEnumerable<Catalog>> GetCatalogAsync(string accountFromHeader, Catalog_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<Catalog_ServiceClient, Catalog_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCatalogAsync(): {exception.Message}");
            }
        }

        internal Catalog_Filter[] SingleCatalogFilter(string criteria, Catalog_Fields field)
        {
            return new Catalog_Filter[]
            {
                new Catalog_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }

        internal Catalog_Filter[] ExtendCatalogFilter(Catalog_Filter[] filter, string criteria, Catalog_Fields field)
        {
            return filter.Concat(SingleCatalogFilter(criteria, field)).ToArray();
        }

        #endregion
    }
}
