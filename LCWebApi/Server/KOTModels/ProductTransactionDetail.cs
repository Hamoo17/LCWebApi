using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class ProductTransactionDetail
    {
        public int Id { get; set; }
        public bool IsPurchased { get; set; }
        public int PosItemId { get; set; }
        public int ItemCount { get; set; }
        public DateTime TransactionTime { get; set; }
        public int ItemRate { get; set; }
        public string CustomData { get; set; }
        public int? ProductTransactionId { get; set; }

        public virtual Product2 PosItem { get; set; }
        public virtual ProductTransaction ProductTransaction { get; set; }
    }
}
