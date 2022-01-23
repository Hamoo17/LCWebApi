using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.Models
{
    public partial class Notification
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public long UserId { get; set; }
        public long? OrderId { get; set; }
        public int IsRead { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string Audio { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
