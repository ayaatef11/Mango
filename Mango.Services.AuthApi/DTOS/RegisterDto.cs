﻿namespace Mango.Services.AuthApi.DTOS
{
    public class RegisterDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; }=string.Empty;
        public string? Role { get; set; }=string.Empty;

    }
}
