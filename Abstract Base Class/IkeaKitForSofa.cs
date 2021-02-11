using IkeaGenericDemo.Derived_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaGenericDemo.Abstract_Base_Class
{
    public abstract class IkeaKitForSofa
    {
        // this is a common property we used in a derived class 
        public abstract string Title { get; }
        public abstract string Color { get; }

        // Common method for Inventory

        // method without implentation

        public abstract void Molding();

        // method with implemntation 
        public void GetInventory()
        {
            Sofa s = new Sofa();
            // I need all tools and parts of chair 

            foreach (var tools in s.GetTools())
            {
                Console.WriteLine("Tools:" + tools);
            }
            foreach (var parts in s.GetParts())
            {
                Console.WriteLine("Parts:" + parts);
            }
        }



    }
}
