using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Person
    {
        private string name
        {
            get;set;
        }
        private string surname
        {
            get;set;
        }
        private string birthdata
        {
            get;set;
        }
        private int years
        {
            get;set;
        }
        private long EGN
        {
            get;set;
        }
        private Gender gender
        {
            get;set;
        }

        public Person(string name, string surname, string birthdata, int years, long egn,Gender gender)
        {
            this.name = name;
            this.surname = surname;
            this.birthdata = birthdata;
            this.years = years;
            this.EGN = egn;
            this.gender = gender;
        }
    }
}
