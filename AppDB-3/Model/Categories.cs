using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App_DB_3.Model
{
    // Definice třídy Categories, která reprezentuje kategorii produktů v databázi
    public class Categories
    {
        // Konstruktor třídy Categories inicializuje kolekci produktů
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        [Key] // Atribut, který označuje vlastnost Category_id jako primární klíč v databázi
        public int Category_id { get; set; } // Vlastnost pro uchování ID kategorie

        public string Category_name { get; set; } // Vlastnost pro uchování názvu kategorie

        // Vlastnost Products je kolekcí, která obsahuje produkty patřící do této kategorie
        // Použití HashSet zajišťuje unikátnost prvků a rychlejší vyhledávání
        public virtual HashSet<Products> Products { get; set; }
    }
}
