using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the IdentityAppUser class
public class IdentityAppUser : IdentityUser
{
    public string Fname { get; set; }
    public string Lname { get; set; }
}

