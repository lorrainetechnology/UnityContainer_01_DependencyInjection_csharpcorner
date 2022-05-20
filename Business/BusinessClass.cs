using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business
{
    public class BusinessClass : IBusiness
    {
        DataClass _dataClass;

        public BusinessClass()
        {
            _dataClass = new DataClass();
        }

        public string GetBusinessData()
        {
            return _dataClass.GetData();
        }
    }
}