using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public sealed class SealedClass
    {
        public int MyProperty { get; set; }
    }

    public class Sample : SealedClass   //this is error - coz you cnnot inherit from a sealed class.
    {

    }


}
