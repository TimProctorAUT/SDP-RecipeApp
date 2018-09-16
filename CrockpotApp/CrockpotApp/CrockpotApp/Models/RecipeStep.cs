using System;
using System.Collections.Generic;
using System.Text;

namespace CrockpotApp.Models
{
    public class RecipeStep
    {
        public int PageID { get; set; }

        public int TotalPages { get; set; }

        public string Title { get; set; }

        public string InstructionText { get; set; }
    }
}
