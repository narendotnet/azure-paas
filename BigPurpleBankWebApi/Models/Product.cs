using System.ComponentModel.DataAnnotations;

namespace BigPurpleBankWebApi.Models
{
    public class Product
    {
        [Required]
        public string ProductId { get; set; }
        public string EffectiveFrom { get; set; }
        public string EffectiveTo { get; set; }
        [Required]
        public string LastUpdated { get; set; }
        [Required]
        public ProductCategory ProductCategory { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Brand { get; set; }
        public string BrandName { get; set; }
        public string ApplicationUri { get; set; }
        [Required]
        public bool IsTailored { get; set; }
        public AdditionalInformation AdditionalInformation { get; set; }
        public List<CardArt> CardArt { get; set; }

    }

    public class CardArt
    {
        public string Title { get; set; }
        public string ImageUri { get; set; }
    }

    public class AdditionalInformation
    {
        public string OverviewUri { get; set; }
        public string TermsUri { get; set; }
        public string EligibilityUri { get; set; }
        public string FeesAndPricingUri { get; set; }
        public string BundleUri { get; set; }
        public List<AdditionalOverviewUris> AdditionalOverviewUris { get; set; }
        public List<AdditionalTermUris> AdditionalTermUris { get; set; }
        public List<AdditionalEligibilityUris> AdditionalEligibilityUris { get; set; }
        public List<AdditionalFeesAndPricingUris> AdditionalFeesAndPricingUris { get; set; }
        public List<AdditionalBundleUris> AdditionalBundleUris { get; set; }

    }

    public class AdditionalBundleUris
    {
        public string Description { get; set; }
        public string AdditionalInfoUri { get; set; }
    }

    public class AdditionalFeesAndPricingUris
    {
        public string Description { get; set; }
        public string AdditionalInfoUri { get; set; }
    }

    public class AdditionalEligibilityUris
    {
        public string Description { get; set; }
        public string AdditionalInfoUri { get; set; }
    }

    public class AdditionalTermUris
    {
        public string Description { get; set; }
        public string AdditionalInfoUri { get; set; }
    }

    public class AdditionalOverviewUris
    {
        public string Description { get; set; }
        public string AdditionalInfoUri { get; set; }
    }

    public enum ProductCategory
    {
        BUSINESS_LOANS,
        CRED_AND_CHRG_CARDS,
        LEASES,
        MARGIN_LOANS,
        OVERDRAFTS,
        PERS_LOANS,
        REGULATED_TRUST_ACCOUNTS,
        RESIDENTIAL_MORTGAGES,
        TERM_DEPOSITS,
        TRADE_FINANCE,
        TRANS_AND_SAVINGS_ACCOUNTS,
        TRAVEL_CARDS
    }
}