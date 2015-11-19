using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    class Employee
    {
        private string _ID;
        public string ID
        {
            get { return _ID; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _DoB;
        public int Age
        {
            get { DateTime DoB; DateTime.TryParse(_DoB, out DoB); return DateTime.Now.Year - DoB.Year; }
        }
        public string DoB
        {
            set { _DoB = value.ToString(); }
        }

        private string _position;
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public Employee (string _ID, string _name, string _DoB, string _position, string _address, string _phone)
        {
            this._ID = _ID;
            this._name = _name;
            this._DoB = _DoB;
            this._address = _address;
            this._phone = _phone;
        }
    }
}
