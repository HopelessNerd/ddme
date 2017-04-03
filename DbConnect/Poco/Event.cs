using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnect.Poco
{
    public class Event
    {

        #region PK's And Scalar Properties
        /// <summary>
        /// Primary surrogate id for this entity
        /// </summary>
        [Key, Required]
        public int Id { get; set; }
        
        /// <summary>
        /// It may contain full name or otdher details
        /// </summary>
        [Column(TypeName = "VARCHAR"), StringLength(50)]
        public string Name { get; set; }

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
        /// It may contain full name or otdher details
        /// </summary>
        [Column(TypeName = "VARCHAR"), StringLength(50)]
        public string Description { get; set; }
        
        #endregion

        #region Navigational Properties
        /// <summary>
        /// User using which patient can login
        /// </summary>
        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }

        public Patient Patient { get; set; }

        #endregion
    }
}
