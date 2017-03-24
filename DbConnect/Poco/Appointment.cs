﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnect.Poco
{
    public class Appointment
    {

        #region PK's And Scalar Properties
        /// <summary>
        /// Primary surrogate id for this entity
        /// </summary>
        [Key, Required]
        public int Id { get; set; }

        /// <summary>
        /// Date on which the new user is created
        /// </summary>
        [Required]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Date on which the new user is created
        /// </summary>
        [Required]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Date on which the new user is created
        /// </summary>
        [Required]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Date on which the new user is created
        /// </summary>
        [Required]
        public bool IsApproved { get; set; }

        #endregion

        #region Navigational Properties
        /// <summary>
        /// User using which patient can login
        /// </summary>
        [Required, ForeignKey("PatientId")]
        public int patientId { get; set; }

        public Patient PatientId { get; set; }


        /// <summary>
        /// User using which patient can login
        /// </summary>
        [Required, ForeignKey("DoctorId")]
        public int doctorId { get; set; }

        public Patient DoctorId { get; set; }
        #endregion
    }
}
