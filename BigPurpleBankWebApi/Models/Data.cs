namespace BigPurpleBankWebApi.Models
{
    public static class Data
    {
        public static List<Product> products => allProducts;

        static List<Product> allProducts = new List<Product>()
        {
            new Product()
            {
                ProductId= "A000",
                EffectiveFrom="2012-12-25T15:43:00-08:00",
                EffectiveTo="2021-12-25T15:43:00-08:00",
                LastUpdated="2012-12-25T15:43:00-08:00",
                ProductCategory=ProductCategory.TERM_DEPOSITS,
                Name= "Trust Loan",
                Description= "This is a new termdeposits loan product",
                Brand="test",
                BrandName="test",
                ApplicationUri="test",
                IsTailored=true,
                AdditionalInformation= new AdditionalInformation()
                {
                    OverviewUri="test",
                    TermsUri="test",
                    EligibilityUri="test",
                    FeesAndPricingUri="test",
                    BundleUri="test"
                },
                CardArt= new List<CardArt>()
                {
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    },
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    }
                }
            },
            new Product()
            {
                ProductId= "A100",
                EffectiveFrom="2012-12-25T15:43:00-08:00",
                EffectiveTo="2021-12-25T15:43:00-08:00",
                LastUpdated="2012-12-25T15:43:00-08:00",
                ProductCategory=ProductCategory.PERS_LOANS,
                Name= "Personal Loan",
                Description= "This is a new personal loan product",
                Brand="test",
                BrandName="test",
                ApplicationUri="test",
                IsTailored=true,
                AdditionalInformation= new AdditionalInformation()
                {
                    OverviewUri="test",
                    TermsUri="test",
                    EligibilityUri="test",
                    FeesAndPricingUri="test",
                    BundleUri="test"
                },
                CardArt= new List<CardArt>()
                {
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    },
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    }
                }
            },
            new Product()
            {
                ProductId= "A200",
                EffectiveFrom="2012-12-25T15:43:00-08:00",
                EffectiveTo="2021-12-25T15:43:00-08:00",
                LastUpdated="2012-12-25T15:43:00-08:00",
                ProductCategory=ProductCategory.RESIDENTIAL_MORTGAGES,
                Name= "House Loan",
                Description= "This is a new house loan product",
                Brand="test",
                BrandName="test",
                ApplicationUri="test",
                IsTailored=true,
                AdditionalInformation= new AdditionalInformation()
                {
                    OverviewUri="test",
                    TermsUri="test",
                    EligibilityUri="test",
                    FeesAndPricingUri="test",
                    BundleUri="test"
                },
                CardArt= new List<CardArt>()
                {
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    },
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    }
                }
            },
            new Product()
            {
                ProductId= "A300",
                EffectiveFrom="2012-12-25T15:43:00-08:00",
                EffectiveTo="2021-12-25T15:43:00-08:00",
                LastUpdated="2012-12-25T15:43:00-08:00",
                ProductCategory=ProductCategory.LEASES,
                Name= "Lease Loan",
                Description= "This is a new lease loan product",
                Brand="test",
                BrandName="test",
                ApplicationUri="test",
                IsTailored=true,
                AdditionalInformation= new AdditionalInformation()
                {
                    OverviewUri="test",
                    TermsUri="test",
                    EligibilityUri="test",
                    FeesAndPricingUri="test",
                    BundleUri="test"
                },
                CardArt= new List<CardArt>()
                {
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    },
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    }
                }
            },
            new Product()
            {
                ProductId= "A400",
                EffectiveFrom="2012-12-25T15:43:00-08:00",
                EffectiveTo="2021-12-25T15:43:00-08:00",
                LastUpdated="2012-12-25T15:43:00-08:00",
                ProductCategory=ProductCategory.TRADE_FINANCE,
                Name= "Trade Loan",
                Description= "This is a new trade loan product",
                Brand="test",
                BrandName="test",
                ApplicationUri="test",
                IsTailored=true,
                AdditionalInformation= new AdditionalInformation()
                {
                    OverviewUri="test",
                    TermsUri="test",
                    EligibilityUri="test",
                    FeesAndPricingUri="test",
                    BundleUri="test"
                },
                CardArt= new List<CardArt>()
                {
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    },
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    }
                }
            },
            new Product()
            {
                ProductId= "A500",
                EffectiveFrom="2012-12-25T15:43:00-08:00",
                EffectiveTo="2021-12-25T15:43:00-08:00",
                LastUpdated="2012-12-25T15:43:00-08:00",
                ProductCategory=ProductCategory.REGULATED_TRUST_ACCOUNTS,
                Name= "Trust Loan",
                Description= "This is a new trust loan product",
                Brand="test",
                BrandName="test",
                ApplicationUri="test",
                IsTailored=true,
                AdditionalInformation= new AdditionalInformation()
                {
                    OverviewUri="test",
                    TermsUri="test",
                    EligibilityUri="test",
                    FeesAndPricingUri="test",
                    BundleUri="test"
                },
                CardArt= new List<CardArt>()
                {
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    },
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    }
                }
            },
            new Product()
            {
                ProductId= "A600",
                EffectiveFrom="2012-12-25T15:43:00-08:00",
                EffectiveTo="2021-12-25T15:43:00-08:00",
                LastUpdated="2012-12-25T15:43:00-08:00",
                ProductCategory=ProductCategory.BUSINESS_LOANS,
                Name= "Trust Loan",
                Description= "This is a new business loan product",
                Brand="test",
                BrandName="test",
                ApplicationUri="test",
                IsTailored=true,
                AdditionalInformation= new AdditionalInformation()
                {
                    OverviewUri="test",
                    TermsUri="test",
                    EligibilityUri="test",
                    FeesAndPricingUri="test",
                    BundleUri="test"
                },
                CardArt= new List<CardArt>()
                {
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    },
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    }
                }
            },
            new Product()
            {
                ProductId= "A700",
                EffectiveFrom="2012-12-25T15:43:00-08:00",
                EffectiveTo="2021-12-25T15:43:00-08:00",
                LastUpdated="2012-12-25T15:43:00-08:00",
                ProductCategory=ProductCategory.CRED_AND_CHRG_CARDS,
                Name= "Trust Loan",
                Description= "This is a new cards loan product",
                Brand="test",
                BrandName="test",
                ApplicationUri="test",
                IsTailored=true,
                AdditionalInformation= new AdditionalInformation()
                {
                    OverviewUri="test",
                    TermsUri="test",
                    EligibilityUri="test",
                    FeesAndPricingUri="test",
                    BundleUri="test"
                },
                CardArt= new List<CardArt>()
                {
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    },
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    }
                }
            },
            new Product()
            {
                ProductId= "A800",
                EffectiveFrom="2012-12-25T15:43:00-08:00",
                EffectiveTo="2021-12-25T15:43:00-08:00",
                LastUpdated="2012-12-25T15:43:00-08:00",
                ProductCategory=ProductCategory.CRED_AND_CHRG_CARDS,
                Name= "Trust Loan",
                Description= "This is a new cards loan product",
                Brand="test",
                BrandName="test",
                ApplicationUri="test",
                IsTailored=true,
                AdditionalInformation= new AdditionalInformation()
                {
                    OverviewUri="test",
                    TermsUri="test",
                    EligibilityUri="test",
                    FeesAndPricingUri="test",
                    BundleUri="test"
                },
                CardArt= new List<CardArt>()
                {
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    },
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    }
                }
            },
            new Product()
            {
                ProductId= "A900",
                EffectiveFrom="2012-12-25T15:43:00-08:00",
                EffectiveTo="2021-12-25T15:43:00-08:00",
                LastUpdated="2012-12-25T15:43:00-08:00",
                ProductCategory=ProductCategory.OVERDRAFTS,
                Name= "Trust Loan",
                Description= "This is a new overdrafts loan product",
                Brand="test",
                BrandName="test",
                ApplicationUri="test",
                IsTailored=true,
                AdditionalInformation= new AdditionalInformation()
                {
                    OverviewUri="test",
                    TermsUri="test",
                    EligibilityUri="test",
                    FeesAndPricingUri="test",
                    BundleUri="test"
                },
                CardArt= new List<CardArt>()
                {
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    },
                    new CardArt()
                    {
                        Title="test",
                        ImageUri="test"
                    }
                }
            }
        };
    }
}
