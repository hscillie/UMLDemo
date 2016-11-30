using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UMLDemo
{
    public class SoftwareDeveloper : Profession, IProgrammer
    {
        public override void GoToWork()
        {
            throw new NotImplementedException();
        }
    }
}