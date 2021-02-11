using IkeaGenericDemo.Abstract_Base_Class;
using IkeaGenericDemo.Derived_Class.BedType;
using IkeaGenericDemo.Derived_Class.ChairType;
using IkeaGenericDemo.Derived_Class.SofaType;
using System;

namespace IkeaGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("................ Chair type...............");
            // Call chair type Fnood
            var fnood = new Fnood();
            Console.WriteLine(fnood.Title);
            Console.WriteLine(fnood.Color);
            fnood.GetInventory();

            // Call chair type snoolma
            var snoolma = new Snoolma();
            Console.WriteLine(snoolma.Title);
            Console.WriteLine(snoolma.Color);
            snoolma.GetInventory();

            Console.WriteLine("................ Sofa type...............");
            // Call chair type kivik
            var kivik = new Kivik();
            Console.WriteLine(kivik.Title);
            Console.WriteLine(kivik.Color);
            kivik.GetInventory();
            // Call chair type kivik
           var morabo = new Morabo();
            Console.WriteLine(morabo.Title);
            Console.WriteLine(morabo.Color);
            morabo.GetInventory();


            // Call bed type kivik
            var flat = new FlatBed();
            Console.WriteLine(flat.Title);
            Console.WriteLine(flat.Color);
            




        }
    }
}
