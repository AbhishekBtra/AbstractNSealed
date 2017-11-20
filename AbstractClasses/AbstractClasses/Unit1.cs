using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Unit1 : ArtificialIntelligenceCourse
    {
        public override void SomeText() // error because SomeText() is sealed in ArtificialIntelligenceCourse
        {

        }
    }
}
