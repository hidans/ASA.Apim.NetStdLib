using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASA.Apim.NetStdLib.Models
{
    public class ReservationResult
    {
        [Required(ErrorMessage = "Please enter PortalOrderID.")]
        public string PortalOrderID { get; set; }

        [Required(ErrorMessage = "Please enter CourseHeaderID.")]
        public string CourseHeaderID { get; set; }

        //[Required(ErrorMessage = "Please enter ParticipantID.")]
        public string ParticipantID { get; set; }

        [Required(ErrorMessage = "Please enter PortalQuantity, at least = 1.")]
        [Range(1, 500, ErrorMessage = "Must be between 1 and 500")]
        public int PortalQuantity { get; set; } = 1;

        public int ReturnResult { get; set; }
        public string BackendReservationID { get; set; }
        public DateTime ReservationTimeout { get; set; }
    }
}
