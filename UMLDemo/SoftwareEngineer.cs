using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UMLDemo
{
    public class SoftwareEngineer : Profession, IProgrammer, IManager
    {
        public void FixHardware()
        {
            throw new NotImplementedException();
        }

        public override void GoToWork()
        {
            throw new NotImplementedException();
        }
    }
}