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
    ///1) PageID            - Integer value defining the current page/step number this value is.
    ///2) TotalPages        - Integer value defining the Total number of steps/pages in a recipe.
    ///3) Title             - String value defining the Title given to this specific stage of cooking
    ///4) InstructionText   - String value hold the main text of instructions for this specific page/step in the recipe
    ///5) HasTimer          - Boolean value that Hold a true or false value of if a timer is needed on this RecipeStep
    ///6) TimerMinuteCount  - Integer value that holds the total amount of minutes in the RecipeStep
    ///7) TimerSecondCount  - Integer value that holds the total amount of seconds in the RecipeStep
    /// </remarks>
    public class RecipeStep
    {
        public int PageID { get; set; }

        public int TotalPages { get; set; }

        public string Title { get; set; }

        public string InstructionText { get; set; }

        public bool HasTimer { get; set; }

        public int TimerMinuteCount { get; set; }

        public int TimerSecondCount { get; set; }
    }
}
