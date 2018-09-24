using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using CrockpotApp.Models;

namespace CrockpotApp.Unit_Tests
{
    class TestIngredientValidity
    {
        Assert Assert = new Assert();
        TestCase TestCase = new TestCase();
        
        public TestIngredientValidity()
        {
            
        }
        public bool ValidateIngredientName(string name)
        {
            return Assert.True(TestCase.ValidateString(name));
        }

    }
}
