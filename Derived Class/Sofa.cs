using IkeaGenericDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaGenericDemo.Derived_Class
{
    // multiple inheritance 
    public class Sofa : IToolKit, IPart
    {
        // concerte implemntation of sofa
        public string[] GetParts()
        {
            return new string[] { "4 legs", "cushion", "multi form" };
        }
        public string[] GetTools()
        {
            return new string[] { "Big hammer", "small Screwdriver" };
        }
    }
}
