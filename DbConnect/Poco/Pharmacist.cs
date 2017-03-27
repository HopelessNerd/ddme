using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DbConnect.Poco
{
    public class Pharmacist
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
        /// surname or last name of a family member
        /// </summary>
        
        [Column(TypeName = "VARCHAR"), StringLength(25), Required]
        public string LastName { get; set; }

        /// <summary>
        /// surname or last name of a family member
        /// </summary>

        [Column(TypeName = "VARCHAR"), StringLength(25), Required]
        public string PharmacyName { get; set; }

        /// <summary>
        /// mobile number of a family member
        /// </summary>        
        [Column(TypeName = "VARCHAR"), StringLength(20)]
        public string MobileNo { get; set; }

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
        [Column("country", TypeName = "VARCHAR"), StringLength(25)]
        public string Country { get; set; }


        #region "Gender"
        /// <summary>
        /// It will identify sex of a member
        /// </summary>
        
        private Int16 _gender { get; set; }
        /// <summary>
        /// set gender of a family member  
        /// </summary>
        
        [Column("gender"), Required]
        public Gender Gender
        {
            get { return (Gender)this._gender; }
            set { this._gender = (Int16)value; }
        }
        #endregion
                
        #endregion


        #region Navigational Properties

        /// <summary>
        /// User using which patient can login
        /// </summary>
        [Required, ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        #endregion
    }
}
