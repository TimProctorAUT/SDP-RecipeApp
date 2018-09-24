using System;
using System.Collections.Generic;
using System.Text;

namespace CrockpotApp.Unit_Tests
{
    class Assert
    {
        public bool isValid { get; set; }


        public bool False(bool outcome)
        {
            isValid = true;

            if (outcome == true)
            {
                isValid = false;
            }

            return isValid;
        }

        public bool True(bool outcome)
        {
            isValid = false;

            if (outcome == true)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
