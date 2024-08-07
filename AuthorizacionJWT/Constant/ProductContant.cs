using AuthorizacionJWT.Models;

namespace AuthorizacionJWT.Constant
{
    public class ProductContant
    {
        public static List<ProductModels> Products = new List<ProductModels>()
        {
            new ProductModels() { Name = "Coca Cola", Description = "Bebida con gas" },
            new ProductModels() { Name = "Agua Villavicencio", Description = "Agua mineral de 2L" },
        };
    }
}
