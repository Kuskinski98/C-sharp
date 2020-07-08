using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student : Person
    {
        private long fNum
        {
            get;set;
        }

        public Student(string name, string surname, string birthdata, int years, long egn, Gender gender, long fNum): 
            base(name,surname,birthdata,years,egn,gender)
        {
            this.fNum = fNum;
        }

    }
}
