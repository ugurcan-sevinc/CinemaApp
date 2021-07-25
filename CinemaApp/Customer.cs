using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp
{
    class Customer
    {
        string _name;
        string _tcno;
        string _gender;
        int _takenSeatNo;

        public Customer(){}

        public string Name{ get { return _name; } set { _name = value; } }
        public string Tcno { get { return _tcno; } set { _tcno = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public int TakenSeatNo { get { return _takenSeatNo; } set { _takenSeatNo = value; } }


    }
}
