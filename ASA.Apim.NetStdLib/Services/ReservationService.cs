using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Models;
using ASA.Apim.NetStdLib.Security;
using System;
using System.Threading.Tasks;
using WebshopBasketManagement_WebService;
using EnvironmentAppsettings;

namespace ASA.Apim.NetStdLib.Services
{
    public class ReservationService
    {
        private readonly ApiManagerCredentials _credentials;
        private readonly AppSettings _appSettings;

        public ReservationService(ApiManagerCredentials credentials, AppSettings appSettings)
        {
            _credentials = credentials;
            _appSettings = appSettings;
        }

        #region Reservation

        /// <summary>
        /// Create a reservation for courseEnrollment.
        /// </summary>
        /// <param name="portalOrderID">The Id of the Portal from which the request is made. [Required]</param>
        /// <param name="courseHeaderID">The Id of the CourseHeader. [Required]</param>
        /// <param name="participantID">The Id of the Participant. [Required]</param>
        /// <param name="portalQuantity">The number of reservation on the specific course number.</param>
        /// <returns>Return ReservationResult containing ReturnResult that equals 0 for OK, 1 for Course not available and 255 for Could not create reservation. Reason unknown </returns>
        public async Task<ReservationResult> ReserveCourseEnrollment(string portalOrderID, string courseHeaderID, int portalQuantity = 1)
        {
            return await ReserveCourseEnrollmentAsync(portalOrderID, courseHeaderID, portalQuantity);
        }
        internal async Task<ReservationResult> ReserveCourseEnrollmentAsync(string portalOrderID, string courseHeaderID, int portalQuantity)
        {
            try
            {
                var result = new ReservationResult()
                {
                     PortalOrderID = portalOrderID,
                      CourseHeaderID = courseHeaderID,
                       PortalQuantity = portalQuantity
                };
                
                string backendReservationID = string.Empty;
                DateTime reservationTimeout = DateTime.MinValue;
                //participantID = participantID ?? string.Empty;

                var genericServiceClientHelper = new GenericServiceClientHelper<WebshopBasketManagement_ServiceClient, WebshopBasketManagement_Service>(_credentials, _appSettings);
                var service = genericServiceClientHelper.GetServiceClient();
                var response = service.ReserveCourseEnrollmentAsync(portalOrderID, courseHeaderID, string.Empty, backendReservationID, reservationTimeout, portalQuantity).Result;
                result.ReturnResult = response.Body.return_value;
                result.BackendReservationID = response.Body.backendReservationID;
                result.ReservationTimeout = response.Body.reservationTimeout;
                await service.CloseAsync();

                return result;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in ReserveCourseEnrollment(): {exception.Message}");
            }
        }

        /// <summary>
        /// Delete a reservation for courseEnrollment.
        /// </summary>
        /// <param name="portalOrderID">The Id of the Portal from which the request is made. [Required]</param>
        /// <param name="backendReservationID">The Id given by the Backend to the Reservation. [Required]</param>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <returns></returns>
        public async Task<bool> RemoveReservation(string portalOrderID, string backendReservationID)
        {
            return await RemoveReservationAsync(portalOrderID, backendReservationID);
        }
        internal async Task<bool> RemoveReservationAsync(string portalOrderID, string backendReservationID)
        {
            try
            {
                var genericServiceClientHelper = new GenericServiceClientHelper<WebshopBasketManagement_ServiceClient, WebshopBasketManagement_Service>(_credentials, _appSettings);
                var service = genericServiceClientHelper.GetServiceClient();
                var result = await service.RemoveReservationAsync(portalOrderID, backendReservationID);
                await service.CloseAsync();
                return result.return_value;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in RemoveReservation(): {exception.Message}");
            }
        }

        /// <summary>
        /// Check whether a reservation for a courseEnrollment exists.
        /// </summary>
        /// <param name="portalOrderID">The Id of the Portal from which the request is made. [Required]</param>
        /// /// <param name="backendReservationID">The Id given by the Backend to the Reservation. [Required]</param>
        /// <returns></returns>
        public async Task<bool> ExistsReservation(string portalOrderID, string backendReservationID)
        {
            return await ExistsReservationAsync(portalOrderID, backendReservationID);
        }
        internal async Task<bool> ExistsReservationAsync(string portalOrderID, string backendReservationID)
        {
            try
            {
                DateTime reservationTimeout = DateTime.MinValue;
                var genericServiceClientHelper = new GenericServiceClientHelper<WebshopBasketManagement_ServiceClient, WebshopBasketManagement_Service>(_credentials, _appSettings);
                var service = genericServiceClientHelper.GetServiceClient();
                var result = await service.ExistsReservationAsync(portalOrderID, backendReservationID, reservationTimeout);
                await service.CloseAsync();
                return result.Body.return_value;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error in ExistsReservation(): {exception.Message}");
            }
        }

        #endregion

    }
}
