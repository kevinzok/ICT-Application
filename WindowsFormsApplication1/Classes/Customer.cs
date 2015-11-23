using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    class Customer
    {
        private string ID;
        public string _ID
        {
            get { return ID; }
        }
        private string name;
        public string _Name
        {
            get { return name; }
            set { name = value; }
        }

        private string AdditionalDetails;
        {
            get (return AdditionalDetails);
        }
       

        public Customer (string _ID, string _name, string _AdditionalDetails)
        {
            this.ID = _ID;
            this.name = _name;
            this.AdditionalDetails = _AdditionalDetails;
            
        }
    }
}