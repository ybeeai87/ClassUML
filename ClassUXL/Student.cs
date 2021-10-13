using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUXL
{
    class Student : Person
    {
        //properties
        private string _program;
        private int _year;
        private double _fee;

        public string Program
        {
            get { return _program; }
            set { _program = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public double Fee
        {
            get { return _fee; }
            set { _fee = value; }
        }

        //constructors
        public Student(string name, string address, string program, int year, double fee ): base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        public Student()
        {

        }
        //methods

        //override ToString method
        public override string ToString()
        {
            return $"{base.ToString()}, Program: {Program}, Year: {Year}, Fee: {Fee}";
        }
    }
}
