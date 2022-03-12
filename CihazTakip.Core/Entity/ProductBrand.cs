using System.Collections.Generic;

namespace CihazTakip.Core.Entity
{
    public class ProductBrand : Identify<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<BrandModel> BrandModels { get; set; }
    }
}
