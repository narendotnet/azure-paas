namespace BigPurpleBankWebApi.Models
{
    public static class Data
    {
        public static List<Product> products => allProducts;

        static List<Product> allProducts = new List<Product>()
        {
            new Product()
            {
                ProductId= "123",
                Name= "Personal Loan",
                Description= "this is a new product"
            },
            new Product()
            {
                ProductId= "456",
                Name= "Car Loan",
                Description= "this is a new product"
            },
            new Product()
            {
                ProductId= "789",
                Name= "Houses Loan",
                Description= "this is a new product"
            }
        };
    }
}
