using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;


namespace Jackson_Brynne_HW4.Models
{
    public class AppUser : IdentityUser
    {
        //phone number, email, ID are al inherited from IdentityUser and don't need to be added

        //First name is provided as an example
        public String FirstName { get; set; }

        //create last name
        public String LastName { get; set; }
        

    }
}