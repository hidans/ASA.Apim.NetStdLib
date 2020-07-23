using ASA.Apim.NetStdLib.Helpers;
using ASA.Apim.NetStdLib.Models;
using ASA.Apim.NetStdLib.Security;
using EnvironmentAppsettings;
using System;
using System.Threading.Tasks;
using WebshopBasketManagement_WebService;

namespace ASA.Apim.NetStdLib.Services
{
    public class ReservationService: BaseService
    {
        public ReservationService(ApiManagerCredentials credentials, AppSettings appSettings):base(credentials, appSettings){ }

        #region Reservation

        /// <summary>
        /// Create a reservation for courseEnrollment.
        /// </summary>
        /// <param name="portalOrderID">The Id of the Portal from which the request is made. [Required]</param>
        /// <param name="courseHeaderID">The Id of the CourseHeader. [Required]</param>
        /// <param name="participantID">The Id of the Participant. [Required]</param>
        /// <param name="portalQuantity">The number of reservation on the specific course number.</param>
        /// <returns>Return ReservationResult containing ReturnResult that equals 0 for OK, 1 for Course not available and 255 for Could not create reservation. Reason unknown </returns>
        public async Task<ReservationResult> ReserveCourseEnrollment(string accountFromHeader, string portalOrderID, string courseHeaderID, int portalQuantity = 1)
        {
            return await ReserveCourseEnrollmentAsync(accountFromHeader, portalOrderID, courseHeaderID, portalQuantity);
        }
        internal async Task<ReservationResult> ReserveCourseEnrollmentAsync(string accountFromHeader, string portalOrderID, string courseHeaderID, int portalQuantity)
        {
            try
            {
                UseAccountFromHeader(accountFromHeader);

                var result = new ReservationResult()
                {
                    PortalOrderID = portalOrderID,
                    CourseHeaderID = courseHeaderID,
                    PortalQuantity = portalQuantity
                };

                string backendReservationID = string.Empty;
                DateTime reservationTimeout = DateTime.MinValue;
                //participantID = participantID ?? string.Empty;

                var genericServiceClientHelper = new GenericServiceClientHelper<WebshopBasketManagement_ServiceClient, WebshopBasketManagement_Service>(Credentials, AppSettings);
                var service = genericServiceClientHelper.GetServiceClient();
                var response = await service.ReserveCourseEnrollmentAsync(portalOrderID, courseHeaderID, string.Empty, backendReservationID, reservationTimeout, portalQuantity);
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

        private void UseAccountFromHeader(string accountFromHeader)
        {
            //Workaround: AccountKey in Credentials must be provided as a request header.
            Credentials.AccountKey = accountFromHeader;
        }

        /// <summary>
        /// Delete a reservation for courseEnrollment.
        /// </summary>
        /// <param name="portalOrderID">The Id of the Portal from which the request is made. [Required]</param>
        /// <param name="backendReservationID">The Id given by the Backend to the Reservation. [Required]</param>
        /// <param name="subscriptionKey">Signup in Api Manager to get a key. [Required]</param>
        /// <param name="accountKey">Account key from Navision. [Required]</param>
        /// <returns></returns>
        public async Task<bool> RemoveReservation(string accountFromHeader, string portalOrderID, string backendReservationID)
        {
            return await RemoveReservationAsync(accountFromHeader, portalOrderID, backendReservationID);
        }
        internal async Task<bool> RemoveReservationAsync(string accountFromHeader, string portalOrderID, string backendReservationID)
        {
            try
            {
                UseAccountFromHeader(accountFromHeader);

                var genericServiceClientHelper = new GenericServiceClientHelper<WebshopBasketManagement_ServiceClient, WebshopBasketManagement_Service>(Credentials, AppSettings);
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
        public async Task<bool> ExistsReservation(string accountFromHeader, string portalOrderID, string backendReservationID)
        {
            return await ExistsReservationAsync(accountFromHeader, portalOrderID, backendReservationID);
        }
        internal async Task<bool> ExistsReservationAsync(string accountFromHeader, string portalOrderID, string backendReservationID)
        {
            try
            {
                UseAccountFromHeader(accountFromHeader);

                DateTime reservationTimeout = DateTime.MinValue;
                var genericServiceClientHelper = new GenericServiceClientHelper<WebshopBasketManagement_ServiceClient, WebshopBasketManagement_Service>(Credentials, AppSettings);
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
