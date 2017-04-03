using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DbConnect.Poco
{
    public class TestResult
    {

        #region PK's And Scalar Properties
        /// <summary>
        /// Primary surrogate id for this entity
        /// </summary>
        [Key, Required]
        [Column("Id")]
        public int Id { get; set; }

        /// <summary>
        /// It may contain full name or other details
        /// </summary>
        [Column("Description", TypeName = "VARCHAR"), StringLength(50)]
        public string Description { get; set; }
        
        /// <summary>
        /// Date on which the new user is created
        /// </summary>
        [Column("CreationDate"), Required]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Weight of the patient in KGs
        /// </summary>
        [Required]
        public float Weight { get; set; }

        /// <summary>
        /// Height of the patient in KGs
        /// </summary>
        [Required]
        public float Height { get; set; }

        /// <summary>
        /// Height of the patient in KGs
        /// </summary>
        [Required]
        public float Waist { get; set; }

        /// <summary>
        /// Height of the patient in KGs
        /// </summary>
        [Required]
        public int Score { get; set; }

        /// <summary>
        /// Height of the patient in KGs
        /// </summary>
        [Required]
        public bool IsDiagnosedWithBP { get; set; }

        /// <summary>
        /// Is/Are any relatives of the patient been diagnosed with Diabetes
        /// </summary>
        [Required]
        public bool AreRelativesDiagnosed { get; set; }
        
        /// <summary>
        /// Is/Are any relatives of the patient been diagnosed with Diabetes
        /// </summary>
        [Required]
        public bool IsPhysicallyActive { get; set; }
        
        /// <summary>
        /// Is/Are any relatives of the patient been diagnosed with Diabetes
        /// </summary>
        [Required]
        public bool IsGestationalDiabetes { get; set; }
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
