using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class EdxCourses : OnlineCourseVendors
    {

        /*
         * The purpose of an abstract class is to provide a common definition of a base class that multiple derived classes can share
         * 
         */
        //public abstract string courseName; fields cannot be abstract
        public string courseName;
        public List<string> offeringUniversity;
        public DateTime courseCommencement;
        //properties can be abstract
        public abstract string brouchere { get; set; }


        public override abstract void SearchCourses();

        public virtual void SomeText()
        {
            Console.WriteLine("Some Text");
        }


    }
}
