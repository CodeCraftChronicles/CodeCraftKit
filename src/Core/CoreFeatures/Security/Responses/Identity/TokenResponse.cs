﻿using System;

namespace Core.CoreFeatures.Security.Responses.Identity;

public class TokenResponse
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public string UserImageURL { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public bool PasswordExpired { get; set; } = false;
}