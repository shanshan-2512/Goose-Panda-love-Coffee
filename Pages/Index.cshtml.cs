﻿using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _Net_Lab3_Shanshan.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public string? UserEmail { get; set; }

    public void OnGet()
    {
        if (User.Identity != null)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            if (claimsIdentity.IsAuthenticated)
            {
                var email = claimsIdentity.FindFirst(ClaimTypes.Email);
                if (email != null)
                {
                    UserEmail = email.Value;
                    _logger.Log(LogLevel.Information, email.Value);
                }

                // foreach (var cl in claimsIdentity.Claims)
                // {
                //     _logger.Log(LogLevel.Information, $"{cl.Type}:{cl.Value}");
                // }
            }
        }
    }
}
