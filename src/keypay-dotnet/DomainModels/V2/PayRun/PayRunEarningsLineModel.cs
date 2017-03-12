namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunEarningsLineModel
    {
        public string PayCategoryId { get; set; }
        public decimal Units { get; set; }
        public string Notes { get; set; }
        public string LocationId { get; set; }
        public string PayCategoryName { get; set; }
        public decimal Earnings { get; set; }
        public decimal Super { get; set; }
        public decimal Sfss { get; set; }
        public decimal Help { get; set; }
        public decimal Payg { get; set; }
        public decimal Rate { get; set; }
        public string ExternalId { get; set; }
    }
}