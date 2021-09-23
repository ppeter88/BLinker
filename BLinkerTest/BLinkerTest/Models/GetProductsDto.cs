using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLinkerTest.Models
{
    public class GetProductsDto
    {
        public string storage_id { get; set; }
        public string filter_id { get; set; }

        public GetProductsDto(string storage, string productId)
        {
            storage_id = storage;
            filter_id = productId;
        }
    }
}
