using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DepsWebApp.Models
{
    /// <summary>
    /// Validation model for Registration.
    /// Contains user login and password
    /// </summary>
    public class RegisterValidationModel
    {
        /// <summary>
        /// User Login
        /// </summary>
        [Required(ErrorMessage = "Login field is required!",
            ErrorMessageResourceType = typeof(ArgumentNullException))]
        public string  Login { get; set; }

        /// <summary>
        /// User Password
        /// </summary>
        [Required(ErrorMessage = "Password field is required!",
            ErrorMessageResourceType = typeof(ArgumentNullException))]
        public string Password { get; set; }
    }
}
