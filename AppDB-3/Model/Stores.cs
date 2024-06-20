using System.ComponentModel.DataAnnotations;

namespace App_DB_3.Model
{
    public partial class Store
    {
        [Key]
        public int store_id { get; set; }
        public string store_name { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
        public string street { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string state { get; set; }
    }
}
