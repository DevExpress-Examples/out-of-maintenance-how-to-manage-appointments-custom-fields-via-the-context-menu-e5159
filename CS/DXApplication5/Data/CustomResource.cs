using System;
using System.Collections.Generic;
using System.Linq;

namespace DXApplication5
{
    public class CustomResource
    {

        public CustomResource()
        {

        }
     
        private int _ResourceID;
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
            }
        }

        public int ResourceID
        {
            get { return _ResourceID; }
            set
            {
                _ResourceID = value;
            }
        }




    }
}
