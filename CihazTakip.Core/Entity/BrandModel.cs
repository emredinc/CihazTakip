namespace CihazTakip.Core.Entity
{
    public class BrandModel : Identify<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int BrandId { get; set; }
        public ProductBrand ProductBrand { get; set; }
    }
}
