using System.ComponentModel.DataAnnotations;
namespace App_DB_3.Model
{
    public partial class Orders
    {
        [Key]
        public int order_id { get; set; }
        public int? customer_id { get; set; }
        public int order_status { get; set; }
        public System.DateTime order_date { get; set; }
        public System.DateTime required_date { get; set; }
        public System.DateTime? shipped_date { get; set; }
        public int store_id { get; set; }
        public int staff_id { get; set; }
    }
}
