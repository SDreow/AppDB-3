using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App_DB_3.Model
{
    public class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();

        }
        [Key]
        public int Category_id { get; set; }
        public string Category_name { get; set; }
        public virtual HashSet <Products> Products { get; set; }
    }
}
