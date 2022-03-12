using System.Collections.Generic;

namespace CihazTakip.Core.Entity
{
    public class Product : Identify<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<ProductBrand> ProductBrands { get; set; }
    }
}
