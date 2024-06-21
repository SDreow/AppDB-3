using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.ComponentModel.DataAnnotations;

namespace App_DB_3.Model
{
    public partial class Customers : IDXDataErrorInfo
    {
        [Key]
        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }

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
                case "first_name":
                    if (string.IsNullOrEmpty(first_name))
                    {
                        info.ErrorText = "Jméno nesmí být prázdné";
                        info.ErrorType = ErrorType.Critical;
                    }
                    break;
                case "last_name":
                    if (string.IsNullOrEmpty(last_name))
                    {
                        info.ErrorText = "Příjmení nesmí být prázdné";
                        info.ErrorType = ErrorType.Critical;
                    }
                    break;
                case "phone":
                    if (string.IsNullOrEmpty(phone) || !phone.Contains("+"))
                    {
                        info.ErrorText = "Telefon musí obsahovat znaménko +";
                        info.ErrorType = ErrorType.Critical;
                    }
                    break;
                case "email":
                    if (string.IsNullOrEmpty(email))
                    {
                        info.ErrorText = "Email nemsmý být prázdný";
                        info.ErrorType = ErrorType.Critical;
                    }
                    else if (!email.Contains("@") || !email.Contains("."))
                    {
                        info.ErrorText = "Neplatný formát.";
                        info.ErrorType = ErrorType.Critical;
                    }
                    break;
                case "state":
                    if (string.IsNullOrEmpty(state))
                    {
                        info.ErrorText = "Stát nesmý být prázdný";
                        info.ErrorType = ErrorType.Warning;
                    }
                    break;
            }
        }
    }
}


