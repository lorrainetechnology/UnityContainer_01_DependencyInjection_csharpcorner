using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class DataClass : IData
    {
        public string GetData()
        {
            return "From Data";
        }
    }
}