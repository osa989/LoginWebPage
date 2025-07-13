using Microsoft.AspNetCore.Identity;

namespace LoginWebPage.Models
{
    public class Users: IdentityUser   //inherits from identity user class
    {
        public string FullName {  get; set; }  //now your user has everything from IdentityUser plus FullName.
    }
}
