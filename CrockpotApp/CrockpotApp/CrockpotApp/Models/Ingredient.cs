using System;
using System.Collections.Generic;
using System.Text;

namespace CrockpotApp.Models
{
    /// <summary>
    /// Ingredient.cs - Class Defining the Ingredient Object
    /// </summary>
    /// 
    /// <remarks>
    ///Variables:
    ///1) Name           - Integer value defining The Ingredient Name.
    ///2) Quantity       - Integer value defining the Messurement and Size of the Ingredients needed.
    /// </remarks>
    public class Ingredient
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
    }
}
