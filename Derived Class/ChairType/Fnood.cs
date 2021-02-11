using IkeaGenericDemo.Abstract_Base_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaGenericDemo.Derived_Class.ChairType
{
    // Fnood --> special name of chair 
   public class Fnood : IkeaKit<Chair>
    {
        public override string Title 
        {
            get { return "Fnood"; }
        }

        public override string Color
        {
            get { return "red"; }
        }
        public override void Molding()
        {
            throw new NotImplementedException();
        }
    }
}
