using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Security;
using CourseCategory_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class CourseCategoryService : BaseService
    {
        private readonly CatalogService _catalogService;
        public CourseCategoryService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {
            _catalogService = new CatalogService(credentials, appSettings);
        }

        #region CourseCategory
        /// <summary>
        /// Gets CourseCategories.
        /// </summary>
        /// <param name="accountFromHeader">Account from header.</param>
        /// <param name="size">Number of records returned, 0 => returns all.</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseCategory>> GetCourseCategoriesAsync(string accountFromHeader, int size = 0) 
        {
            var categoriesId = (await _catalogService.GetCategoriesAsync(accountFromHeader)).Select(c => c.Id.ToString());
            var criteria = Tools.GetCriteria(categoriesId);
            var filter = SingleCourseCategoryFilter(criteria, CourseCategory_Fields.Course_Attribute_ID);

            return await GetCourseCategoryAsync(accountFromHeader, filter, size);
        }

        /// <summary>
        /// Gets coursecatalogs.
        /// </summary>
        /// <param name="accountFromHeader">Account from header.</param>
        /// <param name="size">Number of records returned, 0 => returns all.</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseCategory>> GetCourseCatalogsAsync(string accountFromHeader, int size = 0)
        {
            var ids = (await _catalogService.GetCatalogsAsync(accountFromHeader)).Select(c => c.Id.ToString());
            var criteria = Tools.GetCriteria(ids);
            var filter = SingleCourseCategoryFilter(criteria, CourseCategory_Fields.Course_Attribute_ID);

            return await GetCourseCategoryAsync(accountFromHeader, filter, size);
        }

        /// <summary>
        /// Get course categories for given catalog Ids.
        /// </summary>
        /// <param name="accountFromHeader">Account from header.</param>
        /// <param name="ids">Catalog ids.</param>
        /// <param name="size">Number of records returned, 0 => returns all.</param>
        /// <returns></returns>
        public async Task<IEnumerable<CourseCategory>> GetCourseCategoriesByIdAsync(string accountFromHeader, string ids, int size = 0)
        {
            var filter = SingleCourseCategoryFilter(ids, CourseCategory_Fields.Course_Attribute_ID);

            return await GetCourseCategoryAsync(accountFromHeader, filter, size);
        }

        /// <summary>
        /// Get CourseHeaders Ids given a catalog Id to use as a filter in other methods.
        /// </summary>
        /// <param name="accountFromHeader">Account from Header.</param>
        /// <param name="catalogId">Catalog Id.</param>
        /// <param name="size">Number of records returned, 0 => returns all.</param>
        /// <returns></returns>
        public async Task<string> GetCourseNosCriteriaByCatalogIdAsync(string accountFromHeader, string catalogId, int size = 0)
        {
            var ids = (await GetCourseCategoriesByIdAsync(accountFromHeader, catalogId, size)).Select(c => c.Course_Header_No).Distinct();
            var criteria = Tools.GetCriteria(ids);
            return criteria;
        }

        public async Task<IEnumerable<string>> GetCourseNosByCatalogIdAsync(string accountFromHeader, string catalogId, int size = 0)
        {
            var ids = (await GetCourseCategoriesByIdAsync(accountFromHeader, catalogId, size)).Select(c => c.Course_Header_No).Distinct();
            
            return ids;
        }

        internal async Task<IEnumerable<CourseCategory>> GetCourseCategoryAsync(string accountFromHeader, CourseCategory_Filter[] filter, int size)
        {
            try
            {
                //Workaround: AccountKey in Credentials must be provided as a request header.
                Credentials.AccountKey = accountFromHeader;

                var genericServiceClientHelper = new GenericServiceClientHelper<CourseCategory_ServiceClient, CourseCategory_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();

                var response = await service.ReadMultipleAsync(filter, "", size);
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in GetCourseCategoryAsync(): {exception.Message}");
            }
        }

        internal CourseCategory_Filter[] SingleCourseCategoryFilter(string criteria, CourseCategory_Fields field)
        {
            return new CourseCategory_Filter[]
            {
                new CourseCategory_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }

        internal CourseCategory_Filter[] ExtendCourseCategoryFilter(CourseCategory_Filter[] filter, string criteria, CourseCategory_Fields field)
        {
            return filter.Concat(SingleCourseCategoryFilter(criteria, field)).ToArray();
        }
        #endregion
    }
}
