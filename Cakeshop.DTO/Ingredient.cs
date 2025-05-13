using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakeshop.DTO
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int GramAmount { get; set; } // Amount of ingredient in grams

        // Allergen properties
        public bool HasGluten { get; set; }
        public bool HasDairy { get; set; }
        public bool HasEggs { get; set; }
        public bool HasNuts { get; set; }
        public bool HasSoy { get; set; }
        public bool HasWheat { get; set; }
    }
}
