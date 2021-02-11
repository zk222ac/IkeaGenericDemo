using IkeaGenericDemo.Abstract_Base_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkeaGenericDemo.Derived_Class.ChairType
{
    public class Snoolma : IkeaKit<Chair>
    {
        public override string Title
        {
            get { return "Snoolma"; }
        }

        public override string Color
        {
            get { return "green"; }
        }
        public override void Molding()
        {
            throw new NotImplementedException();
        }
    }
}
