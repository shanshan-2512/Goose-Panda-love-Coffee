
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Goose_Panda_Love_Coffee.Models;

public class SiteUser : IdentityUser
{
    [PersonalData]
    public string? Name { get; set; }
    [PersonalData]
    public int StreetNumber { get; set; } = 1;
    [PersonalData]
    public string? StreetName { get; set; }
    [PersonalData]
    [RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please enter postal code in the correct way!")]
    public string? PostalCode { get; set; }

    [PersonalData]
    public string? City { get; set; }
    [PersonalData]
    public string? Province { get; set; }
    [PersonalData]
    public string? Phone { get; set; }

    [PersonalData]
    public string? UserType { get; set; }

}