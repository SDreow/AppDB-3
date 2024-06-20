using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_DB_3.Model
{
    public class Products : IDXDataErrorInfo
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

        public void GetError(ErrorInfo info)
        {
            //info.ErrorType = ErrorType.Critical;
            //info.ErrorText = "This object cannot be saved.";
        }

        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
            Console.WriteLine("Property name: " + propertyName);
            switch (propertyName)
            {
                case "product_name":
                    if (string.IsNullOrEmpty(product_name))
                    {
                        info.ErrorText = "Product name cannot be empty.";
                        info.ErrorType = ErrorType.Critical;
                    }
                    break;
                    case "list_price":
                    if (list_price == 0)
                    {
                        info.ErrorText = "List price must be greater than 0.";
                        info.ErrorType = ErrorType.Warning;
                    }
                    break;   
            }
        }
    }
}
