using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class UserDevice
    {
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public string Notify { get; set; }
        public string DeviceType { get; set; }
        public string DeviceToken { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
