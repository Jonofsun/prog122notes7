using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog122notes7
{
    public class Student
    {

        public string _firstName;
        public string _lastName;
        public int _CSIGrade;
        public int _GenEdGrade;

        public Student(string firstName, string lastName, int cSIGrade, int genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _CSIGrade = cSIGrade;
            _GenEdGrade = genEdGrade;
        }

        //overide ToString()
        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }
    }
}
