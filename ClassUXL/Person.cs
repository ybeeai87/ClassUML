using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUXL
{
    class Person
    {
        //fields
        public string Name { get; set; }
        public string Address { get; set; }

        //properties
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}
        //public string Address
        //{
        //    get { return _address; }
        //    set { _address = value; }
        //}
        //constructors
        public Person()
        {

        }
        public Person(string name, string address)
        {
            this.Name = name;
           this.Address = address;
        }
        //methods

        //override ToString method
        public override string ToString()
        {
            return $"Person: {Name}, Address: {Address}";
        }


    }
}
