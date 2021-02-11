using IkeaGenericDemo.Abstract_Base_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaGenericDemo.Derived_Class.SofaType
{
    class Morabo : IkeaKit<Sofa>
    {
        public override string Title
        {
            get { return "Morabo"; }
        }

        public override string Color
        {
            get { return "pink"; }
        }
        public override void Molding()
        {
            throw new NotImplementedException();
        }
    }
}
