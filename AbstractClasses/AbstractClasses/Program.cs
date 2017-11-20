using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtificialIntelligenceCourse ob = new ArtificialIntelligenceCourse();
            ob.brouchere = "abc";

            OnlineCourseVendors obj = new ArtificialIntelligenceCourse();
            obj.SearchCourses();
            EdxCourses obj1 = new ArtificialIntelligenceCourse();
            obj1.SearchCourses();

            Console.ReadKey();

            
        }
    }
}
