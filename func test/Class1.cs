using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_test
{
    public class Bank
    {
        string _obj = "";
        string _gg = "";
        public Bank(string obj, string gg)
        {

            _obj = obj;
            _gg = gg;

        }
        public string setiit()
        {
            return _obj + _gg;
        }

    }
}
