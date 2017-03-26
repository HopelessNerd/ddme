using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnect.Poco
{
    public class Patient
    {

        #region "PK's and scalar properties"
        /// <summary>
        /// Primary surrogate id for the entity
        /// </summary>
        [Key, Required]
        public int Id { get; set; }

        /// <summary>
        /// first name of a family member
        /// </summary>
        [Column(TypeName = "VARCHAR"), Required, StringLength(25)]
        public string FirstName { get; set; }

        /// <summary>
        /// middle name or father's name of a family member
        /// </summary>
        
        [Column(TypeName = "VARCHAR"), Required, StringLength(25)]
        public string MiddleName { get; set; }

        /// <summary>
        /// surname or last name of a family member
        /// </summary>
        
        [Column(TypeName = "VARCHAR"), StringLength(25), Required]
        public string LastName { get; set; }

        /// <summary>
        /// mobile number of a family member
        /// </summary>
        
        [Column(TypeName = "VARCHAR"), StringLength(20)]
        public string MobileNo { get; set; }

        /// <summary>
        /// mobile number of a family member
        /// </summary>

        [Column(TypeName = "VARCHAR"), StringLength(20)]
        public string AlternativeNo { get; set; }

        /// <summary>
        /// land line number if it exists
        /// </summary>
        
        [Column(TypeName = "VARCHAR"), StringLength(50)]
        public string LandLineNo { get; set; }

        /// <summary>
        /// email address of individual family member
        /// </summary>
        
        [Column(TypeName = "VARCHAR"), StringLength(254)]
        public string Email { get; set; }

        /// <summary>
        /// current address of a family member
        /// </summary>
        
        [Column(TypeName = "VARCHAR"), StringLength(150)]
        public string Address { get; set; }
        
        /// <summary>
        /// current residential country
        /// </summary>        
        [Column(TypeName = "VARCHAR"), StringLength(25)]
        public string Country { get; set; }

        #region "Gender"
        /// <summary>
        /// It will identify sex of a member
        /// </summary>
        
        private Int16 _gender { get; set; }
        /// <summary>
        /// set gender of a family member  
        /// </summary>
        
        [Required]
        public Gender Gender
        {
            get { return (Gender)this._gender; }
            set { this._gender = (Int16)value; }
        }
        #endregion

        /// <summary>
        /// when a member is born
        /// </summary>        
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Date on which the new user is created
        /// </summary>        
        [Required]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Date on which the user details are updated recently
        /// </summary>        
        [Required]
        public DateTime LastUpdatedDate { get; set; }
        
        /// <summary>
        /// current residential country
        /// </summary>
        [Column(TypeName = "VARCHAR"), StringLength(25)]
        public string Ethnicity { get; set; }

        #endregion


        #region Navigational Properties

        /// <summary>
        /// User using which patient can login
        /// </summary>
        [Required, ForeignKey("LoginUserId")]
        public int UserId { get; set; }

        public User LoginUserId { get; set; }

        public List<TestResult> TestResult { get; set; }

        public List<Appointment> Appointments { get; set; }

        public List<Event> Events { get; set; }

        public List<Prescription> Prescriptions { get; set; }
        #endregion
    }
}
