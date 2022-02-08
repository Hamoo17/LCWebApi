using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string PhoneNumber { get; set; }
        public string SecondPhoneNumber { get; set; }
        public string LandLine { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
        public string RememberToken { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? EmirateId { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Floor { get; set; }
        public string FlatNumber { get; set; }
        public string AccessToken { get; set; }
        public string Image { get; set; }
    }
}
