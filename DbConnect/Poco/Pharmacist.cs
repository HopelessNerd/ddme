﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DbConnect.Poco
{
    class Pharmacist
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

        /// <summary>
        /// when a member is born
        /// </summary>
        
        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// when a member expires
        /// </summary>
        
        [Column("date_of_expiry")]
        public DateTime DateOfExpiry { get; set; }

        /// <summary>
        /// age of family member
        /// </summary>
        
        [Column("age")]
        public Int16 Age { get; set; }

        /// <summary>
        /// whether DOB is tentative or not
        /// </summary>
        
        [Column("is_actual")]
        public bool IsActual { get; set; }

        /// <summary>
        /// additional information if required
        /// </summary>
        
        [Column("note1", TypeName = "VARCHAR"), StringLength(100)]
        public string Note1 { get; set; }

        /// <summary>
        /// additional information if required
        /// </summary>
        
        [Column("note2", TypeName = "VARCHAR"), StringLength(100)]
        public string Note2 { get; set; }

        /// <summary>
        /// additional information if required
        /// </summary>
        
        [Column("note3", TypeName = "VARCHAR"), StringLength(100)]
        public string Note3 { get; set; }

        /// <summary>
        /// location of family member's occupation
        /// </summary>
        
        [Column("status_location", TypeName = "VARCHAR"), StringLength(150)]
        public string StatusLocation { get; set; }

        /// <summary>
        /// Date on which the new user is created
        /// </summary>
        
        [Column("creation_date"), Required]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Date on which the user details are updated recently
        /// </summary>
        
        [Column("last_updated_date"), Required]
        public DateTime LastUpdatedDate { get; set; }

        #endregion
    }
}