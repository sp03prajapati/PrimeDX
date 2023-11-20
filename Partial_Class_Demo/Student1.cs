using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class_Demo
{
    public partial class Student
    {
        private string _firstname;
        private string _lastname;
        public string FirstName
        { 
            set { _firstname = value;} 
            get{ return _firstname;}
        }
        public string LastName
        {
            set { _lastname = value; }
            get { return _lastname; }
        }
    }
}
