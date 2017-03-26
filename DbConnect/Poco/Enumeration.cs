using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnect.Poco
{
    /// <summary>
    /// To identify the gender of the person
    /// </summary>
    /// 
    public enum Gender
    {
        Male = 1,
        Female = 2
    }
    
    /// <summary>
    /// Roles of the Users according to their accesibility.
    /// </summary>
    public enum Roles
    {
        Patient = 1,
        Doctor = 2,
        Pharmacist = 3
    }
}
