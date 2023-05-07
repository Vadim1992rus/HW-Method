using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainie.Models
{
    public class Bond
    {
        public string AuctionDate { get; set; }
        public string AuctionNum { get; set; }
        public string ValCode { get; set; }
        public string StockCode { get; set; }
        public string PayDate { get; set; }
        public string RepayDate { get; set; }
        public int DaysToRepay { get; set; }
        public int StockRestrict { get; set; }
        public int StockRestrictN { get; set; }
        public int StockRestrictMF { get; set; }
        public string Bucket { get; set; }
        public float IncomeLevel { get; set; }
        public float AvgLevel { get; set; }
        public int Amount { get; set; }
        public int AmountN { get; set; }
        public float BTC { get; set; }
        public decimal VolumeSubmit { get; set; }
        public decimal VolumeSold { get; set; }
        public decimal VolumeSoldN { get; set; }
        public float Attraction { get; set; }
        public float MinLevel { get; set; }
        public float MaxLevel { get; set; }
    }
}
