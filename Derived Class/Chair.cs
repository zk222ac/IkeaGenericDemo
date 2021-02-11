using IkeaGenericDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaGenericDemo.Derived_Class
{
    public class Chair : IToolKit, IPart
    {
        // concrete implementation of method GetParts
        public string[] GetParts()
        {
            return new string[] {"leg", "leg", "leg", "seat", "back", "bag of screws" };
        }

        // concrete implementation of method GetTools
        public string[] GetTools()
        {
            return new string[] { "Screwdriver", "Allen Key" };
        }
    }
}
