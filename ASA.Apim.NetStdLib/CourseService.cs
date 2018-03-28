using ASA.Apim.NetStdLib.Helpers;
using CourseHeader_WebService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CourseLocationList_WebService;

namespace ASA.Apim.NetStdLib
{
    public static class CourseService
    {
        #region CourseHeaders
        public static IEnumerable<CourseHeader> GetCourseHeadersById(string subscriptionKey, string accountKey = null, string filter = "", int size = 0)
        {
            var CourseHeaderfilter = SingleCourseHeaderFilter(filter, CourseHeader_Fields.No);
            var task = GetCourseHeaders(CourseHeaderfilter, subscriptionKey, accountKey, size);
            return task.Result;
        }
        public static IEnumerable<CourseHeader> GetCourseHeaders(string subscriptionKey, string accountKey = null, int size = 0)
        {
            return GetCourseHeadersById(subscriptionKey, accountKey, "");
        }

        public static async Task<IEnumerable<CourseHeader>> GetCourseHeaders(CourseHeader_Filter[] filter, string accountKey, string subscriptionKey, int size = 0)
        {
            try
            {
                var service = ServiceClientHelper.CourseHeaderServiceClient(accountKey, subscriptionKey);
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
        public static IEnumerable<courseLocationList> GetCourseLocationListById(string subscriptionKey, string accountKey = null, string filter = "", int size = 0)
        {
            var filterArray = SingleCourseLocationListFilter(filter, courseLocationList_Fields.No);
            var task = GetCourseLocationList(filterArray, subscriptionKey, accountKey, size);
            return task.Result;
        }
        public static IEnumerable<courseLocationList> GetCourseLocationList(string subscriptionKey, string accountKey = null, int size = 0)
        {
            return GetCourseLocationListById(subscriptionKey, accountKey, "");
        }

        public static async Task<IEnumerable<courseLocationList>> GetCourseLocationList(courseLocationList_Filter[] filter, string subscriptionKey, string accountKey, int size = 0)
        {
            try
            {
                var service = ServiceClientHelper.CourseLocationListServiceClient(accountKey, subscriptionKey);
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