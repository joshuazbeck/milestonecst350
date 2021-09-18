using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestone.Models
{
    /**
     * Class responsible for holding data relating to a user.  Also, interacts with the database along with form validation code
     * @TODO - Implement
     */
    public class UserModel
    {
        public int Id { get; set; }
      
        public string ConfirmPassword { get; set; }
        //First Name, Last Name, Sex, Age, State, Email Address, Username, and Password

        [Required]
        [DisplayName("First Name:")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name:")]
        public string LastName { get; set; }

        [DisplayName("Sex:")]
        public string Sex { get; set; }

        [DisplayName("Age:")]
        public string Age { get; set; }

        [Required]
        [DisplayName("State:")]
        public string State { get; set; }

        [Required]
        [DisplayName("Email Address:")]
        public string EmailAddress { get; set; }

        [Required]
        [DisplayName("Username:")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Password:")]
        public string Password { get; set; }
    }
}
