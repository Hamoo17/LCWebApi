using System;
using System.Collections.Generic;

#nullable disable

namespace LCWebApi.Server.KOTModels
{
    public partial class SubinvRep
    {
        public int Id { get; set; }
        public int Maxin { get; set; }
        public string Invnum { get; set; }
        public decimal? Total { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Disc { get; set; }
        public string Branch { get; set; }
        public string Emp { get; set; }
        public DateTime? Dates { get; set; }
        public int? Cid { get; set; }
        public string Company { get; set; }
        public string Delvbranch { get; set; }
        public string Custname { get; set; }
        public string Custph { get; set; }
        public string State { get; set; }
        public string Paym { get; set; }
        public string Refrd { get; set; }
        public string Confrm { get; set; }
        public DateTime? Confdate { get; set; }
        public string Confrmon { get; set; }
        public decimal? Refund { get; set; }
        public DateTime? Refunddt { get; set; }
        public decimal? Discam { get; set; }
        public int? Year { get; set; }
        public string Driver { get; set; }
        public string Comm { get; set; }
        public string Comm2 { get; set; }
        public string Comm3 { get; set; }
        public byte[] InvImg { get; set; }
    }
}
