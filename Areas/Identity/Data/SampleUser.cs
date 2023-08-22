using Microsoft.AspNetCore.Identity;


namespace Hospital_Management_System.Areas.Identity.Data
{
    public class SampleUser : IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
