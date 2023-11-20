using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class_Demo
{
   public partial class Student
    {
        public string GetCompleteName()
        {
            return _firstname + " " + _lastname;
        }
    }
}
