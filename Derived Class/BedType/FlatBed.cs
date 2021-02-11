using IkeaGenericDemo.Abstract_Base_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaGenericDemo.Derived_Class.BedType
{
    public class FlatBed : IkeaKit<Bed>
    {
        public override string Title
        {
            get { return "Bed"; }
        }

        public override string Color
        {
            get { return "yellow"; }
        }
        public override void Molding()
        {
            throw new NotImplementedException();
        }
    }
}
