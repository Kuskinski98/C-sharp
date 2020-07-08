using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Teacher : Person
    {
        private long subject
        {
            get; set;
        }

        public Teacher(string name, string surname, string birthdata, int years, long egn, Gender gender, long subject) :
            base(name, surname, birthdata, years, egn, gender)
        {
            this.subject = subject;
        }
    }
}
