using System.ComponentModel.DataAnnotations;

namespace App_DB_3.Model
{
    public class Brands
    {
        [Key]
        public int Brand_id { get; set; }
        public string Brand_Name { get; set; }
    }
}