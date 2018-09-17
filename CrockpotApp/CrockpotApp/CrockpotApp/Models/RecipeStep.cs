using System;
using System.Collections.Generic;
using System.Text;

namespace CrockpotApp.Models
{
    /// <summary>
    /// RecipeStep.cs - Class Defining the RecipeStep Object
    /// </summary>
    /// 
    ///<remarks>
    ///Variables:
    ///1) PageID           - Integer value defining the current page/step number this value is.
    ///2) TotalPages       - Integer value defining the Total number of steps/pages in a recipe.
    ///3) Title            - String value defining
    ///4) InstructionText  - String value defining 
    /// </remarks>
    public class RecipeStep
    {
        public int PageID { get; set; }

        public int TotalPages { get; set; }

        public string Title { get; set; }

        public string InstructionText { get; set; }
    }
}
