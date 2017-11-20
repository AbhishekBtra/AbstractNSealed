using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class ArtificialIntelligenceCourse : EdxCourses
    {
        public override string  brouchere { get; set; }//overriding(derived class impl) abstract propety is MANDATORY, else compiler error

        public override void SearchCourses()
        {
            Console.WriteLine("In class - ArtificialIntelligenceCourse");
            //base.SearchCourses(); //error - cnnot call abstract base member
        }

        public sealed override void SomeText()
        {
            //You can also use the sealed modifier on a method or property that overrides a virtual method or property in a base class.
            Console.WriteLine("Sealed");
        }
    }
}
