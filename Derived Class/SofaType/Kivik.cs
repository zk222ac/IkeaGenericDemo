using IkeaGenericDemo.Abstract_Base_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaGenericDemo.Derived_Class.SofaType
{
    public class Kivik : IkeaKit<Sofa>
    {
        public override string Title
        {
            get { return "kivik"; }
        }

        public override string Color
        {
            get { return "orange"; }
        }
        public override void Molding()
        {
            throw new NotImplementedException();
        }
    }
}
