using System;
using System.Collections.Generic;
using System.Text;

namespace CrockpotApp.Unit_Tests
{
    class TestCase
    {
        public bool IsValid { get; set; }
        
        public bool ValidateString (string input)
        {
            IsValid = false;

            if (input != null)
            {
                IsValid = true;
            }

            return IsValid;
        }
    }
}
