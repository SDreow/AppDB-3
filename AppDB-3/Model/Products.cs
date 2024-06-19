using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_DB_3.Model
{
    public class Products
    {
        public Products()
        {
            product_name = string.Empty;
        }
        [Key]
        public int product_id { get; set; }
        [MaxLength(255)]
        public string product_name { get; set; }
        public int category_id { get; set; }
        [ForeignKey(nameof(category_id))]
        public virtual Categories categories { get; set; }
        public decimal list_price { get; set; }
        public int brand_id { get; set; }
        public short model_year { get; set; }
    }
}
