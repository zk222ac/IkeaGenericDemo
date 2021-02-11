using IkeaGenericDemo.Derived_Class;
using IkeaGenericDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaGenericDemo.Abstract_Base_Class
{
    // first step to make a class generic
    // add <T> after the class name
    // Type contraint new()
    // T --> new() empty constructor
    public abstract class IkeaKit<T> where T : IToolKit,IPart , new()
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
            // creating an object instance of chair type 
            // Chair c = new Chair();
              T c = new T();
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
