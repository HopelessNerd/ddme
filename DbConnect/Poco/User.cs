using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnect.Poco
{
    [Table("User")]
    public class User
    {
        #region PK's And Scalar Properties
        /// <summary>
        /// Primary surrogate id for this entity
        /// </summary>
        [Key, Required]
        [Column("Id")]
        public int Id { get; set; }

        /// <summary>
        /// Unique name used during login
        /// </summary>
        [Column("UserName", TypeName = "VARCHAR"), Index(IsUnique = true), StringLength(20), Required]
        public string UserName { get; set; }

        /// <summary>
        /// It may contain full name or other details
        /// </summary>
        [Column("Description", TypeName = "VARCHAR"), StringLength(50)]
        public string Description { get; set; }

        /// <summary>
        /// It contains password for user
        /// </summary>
        [Column("Password", TypeName = "VARCHAR"), StringLength(50)]
        public string Password { get; set; }

        #region Role
        /// <summary>
        /// It will identify the access permission of particular user
        /// </summary>
        private Int16 _role { get; set; }

        /// <summary>
        /// Set roles of the user for accesiblity.
        /// </summary>
        [Column("role"), Required]
        public Roles Role
        {
            get { return (Roles)this._role; }
            set { this._role = (Int16)value; }
        }
        #endregion


        /// <summary>
        /// Date and Time of the recent update to the row.
        /// </summary>
        [Column("LastUpdateDate"), Required]
        public DateTime LastUpdateDate { get; set; }

        /// <summary>
        /// Date on which the new user is created
        /// </summary>
        [Column("CreationDate"), Required]
        public DateTime CreationDate { get; set; }

        #endregion


        #region Navigational Properties
        public List<Patient> Patients { get; set; }

        public List<Doctor> Doctors { get; set; }

        public List<Pharmacist> Pharmacists { get; set; }
        #endregion

    }
}
