using IkeaGenericDemo.Derived_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaGenericDemo.Abstract_Base_Class
{
    // this abstract class is specific for sofa manufacturing
   public abstract class IkeaKitForChair
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
            Chair c = new Chair();
            // I need all tools and parts of chair 

            foreach (var tools in c.GetTools())
            {
                Console.WriteLine("Tools:" + tools);
            }
            foreach (var parts in c.GetParts())
            {
                Console.WriteLine("Parts:" + parts);
            }
        }



    }
}
