using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUXL
{
    class Staff : Person
    {
        //properties
        public string School { set; get; }
        public double Pay { set; get; }

        //constructors
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.School = school;
            this.Pay = pay;
        }
        public Staff()
        {

        }
        //methods

        //override method of ToString
        public override string ToString()
        {
            return $"{base.ToString()}, School: {School}, Pay: {Pay}";
        }
    }
}
