using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Models;
using ASA.Apim.NetStdLib.Security;
using CourseHeader_WebService;
using CourseSession_WebService;
using EnvironmentAppsettings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASA.Apim.NetStdLib.Services
{
    public class PerformanceTestService : BaseService
    {
        public PerformanceTestService(ApiManagerCredentials credentials, AppSettings appSettings) : base(credentials, appSettings)
        {
        }

        #region CourseHeader
        public async Task<List<TestResult>> PerformCourseHeaderTestAsync(List<TestCase> testCases)
        {
            var results = new List<TestResult>();
            foreach (var item in testCases)
            {
                results.Add(await TestCourseHeaderAsync(item.Account, item.FetchSize, item.Size));
            }

            return results;
        }

        public async Task<TestResult> TestCourseHeaderAsync(string accountFromHeader, int fetchSize, int size)
        {
            var serviceName = "CourseHeader";
            List<CourseHeader> list = new List<CourseHeader>();

            try
            {
                var filter = new CourseHeader_Filter() { Field = CourseHeader_Fields.No, Criteria = "" };
                var filters = new CourseHeader_Filter[] { filter };
                Credentials.AccountKey = accountFromHeader;

                #region usingGenerics
                //Client must gå through GenericServiceHelper.GetClient() to get credentials and environment ApimUrl. To Test.
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseHeader_ServiceClient, CourseHeader_Service>(Credentials, AppSettings); //Generic non static Class
                var service = genericServiceClientHelper.GetServiceClient();
                #endregion

                string bookmarkKey = null;

                var watch = new Stopwatch();
                watch.Start();
                var response = await service.ReadMultipleAsync(filters, bookmarkKey, fetchSize);
                var results = response.ReadMultiple_Result;
                var numberOfRequests = 0;
                while (results.Length > 0)
                {
                    bookmarkKey = results.Last().Key;
                    list.AddRange(results);
                    numberOfRequests++;
                    if (results.Length >= fetchSize && fetchSize != 0 && list.Count < size)
                    {
                        response = await service.ReadMultipleAsync(filters, bookmarkKey, fetchSize);
                        results = response.ReadMultiple_Result;
                    }
                    else break;
                }
                await service.CloseAsync();
                watch.Stop();
                TestResult testResult = CreateTestResults(accountFromHeader, fetchSize, serviceName, list.Count, watch, numberOfRequests);

                return testResult;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in Test{serviceName}Async(): {exception.Message}");
            }
        }
        #endregion

        #region CourseSession
        public async Task<List<TestResult>> PerformCourseSessionTestAsync(List<TestCase> testCases)
        {
            var results = new List<TestResult>();
            foreach (var item in testCases)
            {
                results.Add(await TestCourseSessionAsync(item.Account, item.FetchSize, item.Size));
            }

            return results;
        }

        public async Task<TestResult> TestCourseSessionAsync(string accountFromHeader, int fetchSize, int size)
        {
            var serviceName = "CourseSession";
            List<CourseSession> list = new List<CourseSession>();

            try
            {
                var filter = new CourseSession_Filter() { Field = CourseSession_Fields.No, Criteria = "" };
                var filters = new CourseSession_Filter[] { filter };
                Credentials.AccountKey = accountFromHeader;

                #region usingGenerics
                //Client must gå through GenericServiceHelper.GetClient() to get credentials and environment ApimUrl. To Test.
                var genericServiceClientHelper = new GenericServiceClientHelper<CourseSession_ServiceClient, CourseSession_Service>(Credentials, AppSettings); //Generic non static Class
                var service = genericServiceClientHelper.GetServiceClient();
                #endregion

                string bookmarkKey = null;

                var watch = new Stopwatch();
                watch.Start();
                var response = await service.ReadMultipleAsync(filters, bookmarkKey, fetchSize);
                var results = response.ReadMultiple_Result;
                var numberOfRequests = 0;
                while (results.Length > 0)
                {
                    bookmarkKey = results.Last().Key;
                    list.AddRange(results);
                    numberOfRequests++;
                    if (results.Length >= fetchSize && fetchSize != 0 && list.Count < size)
                    {
                        response = await service.ReadMultipleAsync(filters, bookmarkKey, fetchSize);
                        results = response.ReadMultiple_Result;
                    }
                    else break;
                }
                await service.CloseAsync();
                watch.Stop();
                TestResult testResult = CreateTestResults(accountFromHeader, fetchSize, serviceName, list.Count, watch, numberOfRequests);

                return testResult;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in Test{serviceName}Async(): {exception.Message}");
            }
        }
        #endregion

        private static TestResult CreateTestResults(string accountFromHeader, int fetchSize, string serviceName, int count, Stopwatch watch, int numberOfRequests)
        {
            return new TestResult
            {
                Account = accountFromHeader,
                Created = DateTime.Now,
                ServiceName = serviceName,
                FetchSize = fetchSize,
                ResponseTime = watch.ElapsedMilliseconds,
                ResponseCount = count,
                NumberOfRequest = numberOfRequests,
                AvgResponseTime = watch.ElapsedMilliseconds / numberOfRequests
            };
        }
    }
}
