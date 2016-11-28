using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UMLDemo
{
    public class NetworkAdministrator : Profession, IHardwareFixer
    {
        public override void GoToWork()
        {
            throw new NotImplementedException();
        }
    }
}