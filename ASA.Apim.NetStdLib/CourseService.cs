using ASA.Apim.NetStdLib.Helpers;
using CourseHeader_WebService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CourseLocationList_WebService;
using Microsoft.Extensions.Options;
using ConsumerApiCoreSettings;
using System.ServiceModel;

namespace ASA.Apim.NetStdLib
{
    public static class CourseService
    {
        #region CourseHeaders
        public static IEnumerable<CourseHeader> GetCourseHeadersById(AppSettings appSettings, string subscriptionKey, string accountKey = null, string filter = "", int size = 0)
        {
            var CourseHeaderfilter = SingleCourseHeaderFilter(filter, CourseHeader_Fields.No);
            var task = GetCourseHeaders(appSettings, CourseHeaderfilter, subscriptionKey, accountKey, size);
            return task.Result;
        }
        public static IEnumerable<CourseHeader> GetCourseHeaders(AppSettings appSettings, string subscriptionKey, string accountKey = null, int size = 0)
        {
            return GetCourseHeadersById(appSettings, subscriptionKey, accountKey, "");
        }

        public static async Task<IEnumerable<CourseHeader>> GetCourseHeaders(AppSettings appSettings, CourseHeader_Filter[] filter,  string subscriptionKey, string accountKey, int size = 0)
        {
            try
            {
                //var service = ServiceClientHelper.CourseHeaderServiceClient(accountKey, subscriptionKey, appSettings);//Original
                
                #region usingGenerics
                //Client must gå through GenericServiceHelper.GetClient() to get credentials and environment ApimUrl. To Test.
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseHeader_ServiceClient, CourseHeader_Service>(); //Generic non static Class
                var service = genericServiceClientHelper.GetServiceClient(accountKey, subscriptionKey, appSettings);
                #endregion

                var response = service.ReadMultipleAsync(filter, "", size).Result;
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        internal static CourseHeader_Filter[] SingleCourseHeaderFilter(string criteria, CourseHeader_Fields field)
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
        #endregion

        #region CourseLocations
        public static IEnumerable<courseLocationList> GetCourseLocationListById(AppSettings appSettings, string subscriptionKey, string accountKey = null, string filter = "", int size = 0)
        {
            var filterArray = SingleCourseLocationListFilter(filter, courseLocationList_Fields.No);
            var task = GetCourseLocationList(appSettings, filterArray, subscriptionKey, accountKey, size);
            return task.Result;
        }
        public static IEnumerable<courseLocationList> GetCourseLocationList(AppSettings appSettings, string subscriptionKey, string accountKey = null, int size = 0)
        {
            return GetCourseLocationListById(appSettings, subscriptionKey, accountKey, "");
        }

        public static async Task<IEnumerable<courseLocationList>> GetCourseLocationList(AppSettings appSettings, courseLocationList_Filter[] filter, string subscriptionKey, string accountKey, int size = 0)
        {
            try
            {
                //var service = ServiceClientHelper.CourseLocationListServiceClient(accountKey, subscriptionKey, appSettings);//Original

                #region usingGenerics
                //Client must gå through GenericServiceHelper.GetClient() to get credentials and environment ApimUrl. To Test.
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseLocationList_ServiceClient, CourseLocationList_Service>(); //Generic non static Class
                var service = genericServiceClientHelper.GetServiceClient(accountKey, subscriptionKey, appSettings);
                #endregion

                var response = service.ReadMultipleAsync(filter, "", size).Result;
                await service.CloseAsync();
                return response.ReadMultiple_Result.ToList();
            }
            catch (Exception exception)
            {
                throw new Exception("Fejl i async Task", exception);
            }
        }
        internal static courseLocationList_Filter[] SingleCourseLocationListFilter(string criteria, courseLocationList_Fields field)
        {
            return new courseLocationList_Filter[]
            {
                new courseLocationList_Filter()
                {
                    Field = field,
                    Criteria = criteria
                }
            };
        }
        #endregion
    }
}