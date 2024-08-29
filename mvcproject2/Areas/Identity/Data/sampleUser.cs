using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace mvcproject2.Areas.Identity.Data;

// Add profile data for application users by adding properties to the sampleUser class
public class sampleUser : IdentityUser
{
    [Required]
    
    public string name { get; set; }
}

