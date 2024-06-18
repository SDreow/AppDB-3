using System.ComponentModel.DataAnnotations;

namespace App_DB_3.Model
{
    public class Categories
    {
        [Key]
        public int Category_id { get; set; }
        public string Category_name { get; set; }
    }
}
