using System.Collections.Generic;
using System.Linq;

namespace BLinkerTest.Models
{
    public class GetProductsListResponse
    {
        public string status { get; set; }
        public string storage_id { get; set; }
        public List<Product> products { get; set; }

        public Product GetObject(string productId)
        {
            var product = products.SingleOrDefault(p => p.product_id == productId);
            return product;
        }
    }
}
